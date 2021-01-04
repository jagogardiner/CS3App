using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CSCourseworkApp
{
    class Subjects
    {
        public static BindingList<string> SubjectList = new BindingList<string>();

        public static void PopulateList()
        {
            /*
             * Populates the global list, SubjectList,
             * with the subjects in the Subjects table.
             */
            SubjectList.Clear();
            DataTable dt = SqlTools.GetTable("SELECT SubjectName FROM Subjects");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                SubjectList.Add((string)dt.Rows[i]["SubjectName"]);
            }
        }

        public static void AddNewSubject(string subjectName)
        {
            /*
             * Adds a new subject to the table.
             */
            SqlCommand comm = new SqlCommand("INSERT INTO Subjects (SubjectName) VALUES (@SubjectName)");
            comm.Parameters.AddWithValue("@SubjectName", subjectName);
            SqlTools.ExecuteNonQuery(comm);
            AdminForm.RefreshLists();
        }

        public static void DeleteSubject(string subjectName)
        {
            /*
             * Deletes the specified subject and groups
             * with that subject, and those groups linked with staff.
             */
            int subjectId = GetSubjectIdByName(subjectName);
            SqlCommand comm = new SqlCommand("SELECT GroupId FROM Groups WHERE SubjectId = @SubjectId");
            comm.Parameters.AddWithValue("@SubjectId", subjectId);
            DataTable dt = SqlTools.GetTable(comm);
            SqlCommand deleteCommand = new SqlCommand();
            SqlParameter groupId = new SqlParameter("@GroupId", "");
            deleteCommand.Parameters.Add(groupId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                deleteCommand.CommandText = "DELETE FROM StaffGroupsLink WHERE GroupId = @GroupId";
                groupId.Value = (int)dt.Rows[i]["GroupId"];
                SqlTools.ExecuteNonQuery(deleteCommand);
            }
            comm.CommandText = "DELETE FROM Groups WHERE SubjectId = @SubjectId";
            SqlTools.ExecuteNonQuery(comm);
            comm.CommandText = "DELETE FROM Subjects WHERE SubjectName = @SubjectName";
            comm.Parameters.AddWithValue("@SubjectName", subjectName);
            SqlTools.ExecuteNonQuery(comm);
            AdminForm.RefreshLists();
        }

        public static string GetSubjectName(string groupName)
        {
            /*
             * Gets the subject assinged to a group.
             */
            SqlCommand command = new SqlCommand("SELECT Subjects.SubjectName FROM Groups INNER JOIN Subjects ON Groups.SubjectId=Subjects.SubjectID WHERE Groups.GroupName = @GroupName");
            command.Parameters.AddWithValue("@GroupName", groupName);
            DataTable dt = SqlTools.GetTable(command);
            return dt.Rows[0]["SubjectName"].ToString();
        }

        public static int GetSubjectIdByName(string subjectName)
        {
            /*
             * GetSubjectIdByName gets the SubjectId assigned to a
             * subject name and returns the ID.
             * 
             * Arguments:
             * subjectName (string): Name of the subject.
             */
            SqlCommand command = new SqlCommand("SELECT SubjectId FROM Subjects WHERE SubjectName = @SubjectName");
            command.Parameters.AddWithValue("@SubjectName", subjectName);
            DataTable dt = SqlTools.GetTable(command);
            return (int)dt.Rows[0]["SubjectId"];
        }

        public static double[] GetSubjectMLR(string subjectName)
        {
            /*
             * GetSubjectMLR gets the subject MLR line based from previous results of that subject.
             * This is stored in the database and refreshed only when an admin modifies previous subject
             * results. This is to avoid heavy processing at runtime - the line will never
             * change until new exam results are added.
             * Read more at GradeUtils.calculateGrade().
             * 
             * Arguments:
             * subjectName (string): Name of the subject to get the coeff of.
             */
            SqlCommand command = new SqlCommand("SELECT SubjectWeightConstant, SubjectHomeworkWeight, SubjectTestWeight, SubjectMTGWeight FROM Subjects WHERE SubjectName = @SubjectName");
            command.Parameters.AddWithValue("@SubjectName", subjectName);
            DataTable dt = SqlTools.GetTable(command);
            return new double[] { (double)dt.Rows[0]["SubjectWeightConstant"],
                (double)dt.Rows[0]["SubjectHomeworkWeight"],
                (double)dt.Rows[0]["SubjectTestWeight"],
                (double)dt.Rows[0]["SubjectMTGWeight"] };
        }

        public static void UpdateSubjectMLR(string subjectName)
        {
            int subjectId = GetSubjectIdByName(subjectName);
            UpdateSubjectMLR(subjectId);
        }

        public static void UpdateSubjectMLR(int subjectId)
        {
            /*
             * UpdateSubjectMLR is responsible for re-running the MLR line
             * calculation for a subject. This is a difficult calcuation,
             * so this shouldn't be done too often. After the calcuation is
             * done, store the values of each variable in the MLR equation
             * in the database.
             */
            List<double> homeworkResults = new List<double>();
            List<double> testResults = new List<double>();
            List<double> minimumTargetGrades = new List<double>();
            List<double> finalResults = new List<double>();

            /* Populate all the lists. */
            SqlCommand command = new SqlCommand("SELECT HomeworkResult FROM PreviousResults WHERE SubjectId = @SubjectId");
            command.Parameters.AddWithValue("@SubjectId", subjectId);
            DataTable dt = SqlTools.GetTable(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                homeworkResults.Add((double)dt.Rows[i]["HomeworkResult"]);
            }
            command.CommandText = "SELECT TestResult FROM PreviousResults WHERE SubjectId = @SubjectId";
            dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                testResults.Add((double)dt.Rows[i]["TestResult"]);
            }
            command.CommandText = "SELECT MTGResult FROM PreviousResults WHERE SubjectId = @SubjectId";
            dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                minimumTargetGrades.Add((double)dt.Rows[i]["MTGResult"]);
            }
            command.CommandText = "SELECT FinalResult FROM PreviousResults WHERE SubjectId = @SubjectId";
            dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                finalResults.Add((double)dt.Rows[i]["FinalResult"]);
            }

            /*
             * Calculate the MLR line.
             * Returned double array:
             * MLRLine[0]: Constant
             * MLRLine[1]: Homework result weight
             * MLRLine[2]: Test result weight
             * MLRLine[3]: Minimum target grade weight
             */
            double[] MLRLine = GradeUtils.calculateSubjectMLR(homeworkResults, testResults, minimumTargetGrades, finalResults);
            /*
             * Setup the SQL command.
             * SubjectID doesn't change here.
             */
            command.CommandText = "UPDATE Subjects SET SubjectWeightConstant = @SubjectWeightConstant, " +
                "SubjectHomeworkWeight = @SubjectHomeworkWeight, " +
                "SubjectTestWeight = @SubjectTestWeight, " +
                "SubjectMTGWeight = @SubjectMTGWeight WHERE SubjectID = @SubjectID";
            // Add each parameter.
            command.Parameters.AddWithValue("@SubjectWeightConstant", MLRLine[0]);
            command.Parameters.AddWithValue("@SubjectHomeworkWeight", MLRLine[1]);
            command.Parameters.AddWithValue("@SubjectTestWeight", MLRLine[2]);
            command.Parameters.AddWithValue("@SubjectMTGWeight", MLRLine[3]);

            // Finally, execute the update
            SqlTools.ExecuteNonQuery(command);
        }
    }
}
