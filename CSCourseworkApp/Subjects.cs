using System.Data;
using System.Data.SqlClient;

namespace CSCourseworkApp
{
    class Subjects
    {
        public static string GetSubjectName(string groupName)
        {
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
