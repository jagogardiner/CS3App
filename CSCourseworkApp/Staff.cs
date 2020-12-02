using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CSCourseworkApp
{
    class Staff
    {
        public static BindingList<string> StaffList = new BindingList<string>();

        public static void PopulateList()
        {
            StaffList.Clear();
            DataTable dt = SqlTools.GetTable("SELECT StaffName from Staff");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["StaffName"].ToString();
                // Make sure to skip system admin account - we're the admin.
                if (name != "System Admin")
                {
                    StaffList.Add(name);
                }
            }
        }

        public static int GetPermissionLevel(string staffName)
        {
            /*
             * Returns the integer permission level
             * based off string staffName.
             */
            SqlCommand comm = new SqlCommand("SELECT PermissionLevel FROM Staff WHERE StaffName = @StaffName");
            comm.Parameters.AddWithValue("@StaffName", staffName);
            DataTable dt = SqlTools.GetTable(comm);
            return (int)dt.Rows[0]["PermissionLevel"];
        }

        public static int GetStaffIdByName(string staffName)
        {
            /*
             * Returns the integer of the StaffId based
             * on the given string staffName.
             */
            SqlCommand comm = new SqlCommand("SELECT StaffId FROM Staff WHERE StaffName = @StaffName");
            comm.Parameters.AddWithValue("@StaffName", staffName);
            DataTable dt = SqlTools.GetTable(comm);
            return (int)dt.Rows[0]["StaffId"];
        }

        public static string GetUsername(string staffName)
        {
            /*
             * getUsername gets the login username of the 
             * specified staff member defined by string 
             * staffName.
             */
            SqlCommand comm = new SqlCommand("SELECT StaffUsername FROM Staff WHERE StaffName = @StaffName");
            comm.Parameters.AddWithValue("@StaffName", staffName);
            DataTable dt = SqlTools.GetTable(comm);
            return (string)dt.Rows[0]["StaffUsername"];
        }

        public static BindingList<string> GetGroups(string staffName)
        {
            /*
             * getGroups returns a List of strings of
             * the groups within staff member specified.
             * 
             * Arguments:
             * staffName (string): Name of the group to find the staff members of.
             */
            BindingList<string> groupList = new BindingList<string>();
            // Returns a table with the staff members at that GroupID using StaffGroupsLink table.
            SqlCommand command = new SqlCommand("SELECT Groups.GroupName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE Staff.StaffName = @StaffName");
            command.Parameters.AddWithValue("@StaffName", staffName);
            DataTable dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                groupList.Add(dt.Rows[i]["GroupName"].ToString());
            }
            return groupList;
        }
    }
}
