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
    }
}
