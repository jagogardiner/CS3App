using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSCourseworkApp
{
    class Groups
    {
        public static List<string> GroupList = new List<string>();

        public static void PopulateList()
        {
            /*
             * populateList gets all the Groups
             * available in the database and adds them
             * to the List<string> GroupList.
             */
            DataTable dt = SqlTools.GetTable("SELECT GroupName FROM Groups");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                GroupList.Add(dt.Rows[i]["GroupName"].ToString());
            }
        }

        public static string GetAcademicYear(string groupName)
        {
            /*
             * getAcademicYear gets the academic year
             * assigned to a group and returns the join
             * result.
             * 
             * Arguments:
             * groupName (string): Name of the group to find the year of.
             */
            SqlParameter p = new SqlParameter
            {
                ParameterName = "@GroupName",
                Value = groupName
            };
            SqlCommand command = new SqlCommand("SELECT AcademicYears.AcademicYearName FROM Groups INNER JOIN AcademicYears ON Groups.AcademicYearId=AcademicYears.AcademicYearId WHERE Groups.GroupName = @GroupName");
            command.Parameters.Add(p);
            DataTable dt = SqlTools.GetTable(command);
            return dt.Rows[0]["AcademicYearName"].ToString();
        }

        public static BindingList<string> GetStaff(string groupName)
        {
            /*
             * getStaff returns a List of strings of
             * the staff within group specified.
             * 
             * Arguments:
             * groupName (string): Name of the group to find the staff members of.
             */
            BindingList<string> staffList = new BindingList<string>();
            // Returns a table with the staff members at that GroupID using StaffGroupsLink table.
            SqlCommand command = new SqlCommand("SELECT Staff.StaffName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE Groups.GroupName = @GroupName");
            SqlParameter p = new SqlParameter
            {
                ParameterName = "@GroupName",
                Value = groupName
            };
            command.Parameters.Add(p);
            // Load the returned table into a new DataTable.
            // This is used to grab rows and avoid doing a lot of
            // sql querys which is time consuming.
            DataTable dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                staffList.Add(dt.Rows[i]["StaffName"].ToString());
            }
            return staffList;
        }
    }
}
