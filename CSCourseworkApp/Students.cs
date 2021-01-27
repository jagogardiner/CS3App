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
            for(int i = 0; i < dt.Rows.Count; i++)
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

        public static void AddStudent(string studentName, string studentCollegeId, string academicYearName)
        {
            /*
             * Adds a new student.
             */
            SqlCommand comm = new SqlCommand("");
        }

        public static int GetStudentIdByName(string studentName)
        {
            SqlCommand comm = new SqlCommand("SELECT StudentId FROM Students WHERE StudentName=@StudentName");
            comm.Parameters.AddWithValue("@StudentName", studentName);
            return (int)SqlTools.GetTable(comm).Rows[0]["StudentId"];
        }
    }
}
