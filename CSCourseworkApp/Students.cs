using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CSCourseworkApp
{
    class Students
    {
        public static BindingList<string> StudentList = new BindingList<string>();

        public static void PopulateList()
        {
            StudentList.Clear();
            DataTable dt = SqlTools.GetTable("SELECT StudentName FROM Students");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StudentList.Add((string)dt.Rows[i]["StudentName"]);
            }
        }

        public static string GetUsername(string studentName)
        {
            /*
             * getUsername gets the college username of the 
             * specified student defined by string 
             * studentName.
             */
            SqlCommand comm = new SqlCommand("SELECT StudentCollegeId FROM Students WHERE StudentName = @StudentName");
            comm.Parameters.AddWithValue("@StudentName", studentName);
            DataTable dt = SqlTools.GetTable(comm);
            return (string)dt.Rows[0]["StudentCollegeId"];
        }

        public static string GetAcademicYear(string studentName)
        {
            /*
             * getAcademicYear gets the academic year
             * assigned to a student and returns the join
             * result.
             * 
             * Arguments:
             * groupName (string): Name of the group to find the year of.
             */
            SqlCommand command = new SqlCommand("SELECT AcademicYears.AcademicYearName FROM Students INNER JOIN AcademicYears ON Students.AcademicYearId=AcademicYears.AcademicYearId WHERE Students.StudentName = @StudentName");
            command.Parameters.AddWithValue("@StudentName", studentName);
            DataTable dt = SqlTools.GetTable(command);
            return dt.Rows[0]["AcademicYearName"].ToString();
        }

        public static int GetStudentTableId(string studentName)
        {
            /*
             * GetStudentTableId gets the actual identity value assigned to
             * a student in the database by the student name.
             */
            SqlCommand comm = new SqlCommand("SELECT StudentId FROM Students WHERE StudentName = @StudentName");
            comm.Parameters.AddWithValue("@StudentName", studentName);
            DataTable dt = SqlTools.GetTable(comm);
            return (int)dt.Rows[0]["StudentId"];
        }

        public static BindingList<string> GetGroups(string studentName)
        {
            /*
             * getGroups returns a List of strings of
             * the groups within staff member specified.
             * 
             * Arguments:
             * staffName (string): Name of the group to find the staff members of.
            */
            BindingList<string> groupList = new BindingList<string>();
            // Returns a table with the staff members at that GroupID using StudentGroupsLink table.
            SqlCommand command = new SqlCommand("SELECT Groups.GroupName FROM StudentGroupsLink INNER JOIN Students ON StudentGroupsLink.StudentId=Students.StudentId INNER JOIN Groups ON StudentGroupsLink.GroupId=Groups.GroupId WHERE Students.StudentName = @StudentName");
            command.Parameters.AddWithValue("@StudentName", studentName);
            DataTable dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                groupList.Add(dt.Rows[i]["GroupName"].ToString());
            }
            return groupList;
        }

        public static void DeleteStudent(string studentName)
        {
            /*
             * Deletes the student with the specified student name
             * from the students table and any links to it.
             */
            int studentId = GetStudentTableId(studentName);
            SqlCommand comm = new SqlCommand("DELETE FROM Students WHERE StudentId = @StudentId");
            comm.Parameters.AddWithValue("@StudentId", studentId);
            SqlTools.ExecuteNonQuery(comm);
            AdminForm.RefreshLists();
        }

        public static void EditStudent(string studentName, string studentCollegeId, int academicYearId, BindingList<string> GroupList, out int newstudentId, int studentId = -1)
        {
            /*
             * Adds or edits a student.
             */
            SqlCommand comm = new SqlCommand();
            comm.Parameters.AddWithValue("@StudentName", studentName);
            comm.Parameters.AddWithValue("@StudentCollegeId", studentCollegeId);
            comm.Parameters.AddWithValue("@AcademicYearId", academicYearId);
            if (studentId == -1)
            {
                // If a new student is to be added, insert all values.
                comm.CommandText = "INSERT INTO Students (StudentName, StudentCollegeId, AcademicYearId) ";
                comm.CommandText += "VALUES (@StudentName, @StudentCollegeId, @AcademicYearId)";
                SqlTools.ExecuteNonQuery(comm);
                // Look up new student's ID.
                comm.Parameters.AddWithValue("@StudentId", GetStudentIdByName(studentName));
            }
            else
            {
                comm.CommandText = "UPDATE Students SET StudentName = @StudentName, AcademicYearId = @AcademicYearId, StudentCollegeId = @StudentCollegeId WHERE StudentId=@StudentId";
                comm.Parameters.AddWithValue("@StudentId", studentId);
                SqlTools.ExecuteNonQuery(comm);
                // It is easier to just delete all the matches in group links and re-add them then evaluate what has changed.
                comm.CommandText = "DELETE FROM StudentGroupsLink WHERE StudentId=@StudentId";
                SqlTools.ExecuteNonQuery(comm);
            }
            // Both conditions need the groups to be inserted.
            // Define a new parameter which has a value that can be changed (group ID)
            SqlParameter idParameter = new SqlParameter("@GroupId", 0);
            comm.Parameters.Add(idParameter);
            foreach (string item in GroupList)
            {
                // For each group, insert it into the link table.
                idParameter.Value = Groups.GetGroupIdByName(item);
                comm.CommandText = "INSERT INTO StudentGroupsLink VALUES (@StudentId, @GroupId)";
                SqlTools.ExecuteNonQuery(comm);
            }
            // Return the new student ID (stays the same if a new user was not added)
            newstudentId = studentId;
        }

        public static int GetStudentIdByName(string studentName)
        {
            /*
             * Get a student's database ID by their name
             */
            SqlCommand comm = new SqlCommand("SELECT StudentId FROM Students WHERE StudentName=@StudentName");
            comm.Parameters.AddWithValue("@StudentName", studentName);
            return (int)SqlTools.GetTable(comm).Rows[0]["StudentId"];
        }

        public static void UpdateMTGs(int studentId, Dictionary<int, double> grades)
        {
            /*
             * Update a students minimum target grades.
             */
            // Delete all the mtg's. This is easier than finding what changed and updating them.
            SqlCommand comm = new SqlCommand("DELETE FROM MinimumTargetGrades WHERE StudentId=@StudentId");
            comm.Parameters.AddWithValue("@StudentId", studentId);
            comm.CommandText = "INSERT INTO MinimumTargetGrades VALUES (@StudentId, @SubjectId, @Grade)";
            SqlParameter subjectParameter = new SqlParameter("@SubjectId", 0);
            SqlParameter gradeParameter = new SqlParameter("@Grade", 0);
            comm.Parameters.Add(subjectParameter);
            comm.Parameters.Add(gradeParameter);
            // For each key, add the subject and minimum target grade.
            foreach (int subjectId in grades.Keys)
            {
                subjectParameter.Value = subjectId;
                gradeParameter.Value = grades[subjectId];
                SqlTools.ExecuteNonQuery(comm);
            }
        }
    }
}
