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
            DataTable dt = SqlTools.GetTable("SELECT StaffName FROM Staff");
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

        public static PermissionLevel GetPermissionLevel(string staffUsername)
        {
            SqlCommand comm = new SqlCommand("SELECT PermissionLevel FROM Staff WHERE StaffUsername = @StaffUsername");
            comm.Parameters.AddWithValue("@StaffUsername", staffUsername);
            DataTable dt = SqlTools.GetTable(comm);
            return (PermissionLevel)dt.Rows[0]["PermissionLevel"];
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

        public static int GetStaffIdByUsername(string staffUsername)
        {
            /*
             * Returns the integer of the StaffId based
             * on the given string staffUsername.
             */
            SqlCommand comm = new SqlCommand("SELECT StaffId FROM Staff WHERE StaffUsername = @StaffUsername");
            comm.Parameters.AddWithValue("@StaffUsername", staffUsername);
            DataTable dt = SqlTools.GetTable(comm);
            return (int)dt.Rows[0]["StaffId"];
        }

        public static string GetStaffNameById(int staffId)
        {
            /*
             * Returns the string of the StaffName based
             * on the given string staffId.
             */
            SqlCommand comm = new SqlCommand("SELECT StaffName FROM Staff WHERE StaffId = @StaffId");
            comm.Parameters.AddWithValue("@StaffId", staffId);
            DataTable dt = SqlTools.GetTable(comm);
            return (string)dt.Rows[0]["StaffName"];
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

        public static void DeleteStaffMember(string staffName)
        {
            /*
             * Delete staff member by specified staff name,
             * and group links with that staff member in.
             */
            int staffId = Staff.GetStaffIdByName(staffName);
            SqlCommand comm = new SqlCommand("DELETE FROM StaffGroupsLink WHERE StaffId = @StaffId");
            comm.Parameters.AddWithValue("@StaffId", staffId);
            SqlTools.ExecuteNonQuery(comm);
            comm.CommandText = "DELETE FROM Staff WHERE StaffName = @StaffName";
            comm.Parameters.AddWithValue("@StaffName", staffName);
            SqlTools.ExecuteNonQuery(comm);
            // Repopulate list.
            AdminForm.RefreshLists();
        }
    }
}
