using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SqlCommand comm = new SqlCommand("SELECT StudentCollegeId FROM Staff WHERE StudentName = @StudentName");
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

        public static void AddStudent(string studentName, string academicYearName)
        {

        }
    }
}
