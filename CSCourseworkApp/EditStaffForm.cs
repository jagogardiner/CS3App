using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditStaffForm : Form
    {
        string staffName;
        bool newMember;
        public static BindingList<string> GroupList = new BindingList<string>();
        public EditStaffForm(string staffName = null)
        {
            InitializeComponent();
            if (staffName != null)
            {
                newMember = false;
                staffNameBox.Text = staffName;
                this.staffName = staffName;
                GroupList = Staff.GetGroups(staffName);
                // Get permission level, 3 being tutor, 4 being overseer.
                switch (Staff.GetPermissionLevel(staffName))
                {
                    case 3:
                        tutorCheckBox.Checked = true;
                        break;
                    case 4:
                        overseerCheckBox.Checked = true;
                        break;
                }
                staffUsernameBox.Text = Staff.GetUsername(staffName);
            }
            else
            {
                newMember = true;
                GroupList.Clear();
                titleLabel.Text = "Add Staff Member";
                resetPasswordTickBox.Hide();
            }
        }

        private void EditStaffForm_Load(object sender, System.EventArgs e)
        {
            groupsListBox.DataSource = GroupList;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void addToGroupButton_Click(object sender, System.EventArgs e)
        {
            AddStaffToGroupForm asf = new AddStaffToGroupForm();
            asf.ShowDialog();
        }

        private void saveStaffButton_Click(object sender, System.EventArgs e)
        {
            int permissionLevel = 1; // Default to teacher value.
            if(overseerCheckBox.Checked)
            {
                permissionLevel = 4;
            }
            if(tutorCheckBox.Checked)
            {
                permissionLevel = 2;
            }
            if(!newMember)
            {
                SqlCommand comm = new SqlCommand("UPDATE Staff SET StaffName = @StaffName, PermissionLevel = @PermissionLevel, StaffUsername = @StaffUsername WHERE StaffId = @StaffId");
                comm.Parameters.AddWithValue("@StaffName", staffNameBox.Text);
                comm.Parameters.AddWithValue("@PermissionLevel", permissionLevel);
                comm.Parameters.AddWithValue("@StaffUsername", staffUsernameBox.Text);
                comm.Parameters.AddWithValue("@StaffId", Staff.GetStaffIdByName(staffName));
                SqlTools.ExecuteNonQuery(comm);
                if(resetPasswordTickBox.Checked)
                {
                    comm.CommandText = "UPDATE Staff SET StaffPassword = '' WHERE StaffId = @StaffId";
                    SqlTools.ExecuteNonQuery(comm);
                }
                comm.CommandText = "DELETE FROM StaffGroupsLink WHERE StaffId = @StaffId";
                SqlTools.ExecuteNonQuery(comm);
                SqlParameter p = new SqlParameter("@GroupId", "");
                comm.Parameters.Add(p);
                comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                foreach(string o in GroupList)
                {
                    p.Value = Groups.GetGroupIdByName(o);
                    SqlTools.ExecuteNonQuery(comm);
                }
                Close();
            }
            else
            {
                SqlCommand comm = new SqlCommand("INSERT INTO Staff (StaffName, PermissionLevel, StaffUsername, StaffPassword) VALUES (@StaffName, @PermissionLevel, @StaffUsername, @StaffPassword)");
                comm.Parameters.AddWithValue("@StaffName", staffNameBox.Text);
                comm.Parameters.AddWithValue("@PermissionLevel", permissionLevel);
                comm.Parameters.AddWithValue("@StaffUsername", staffUsernameBox.Text);
                comm.Parameters.AddWithValue("@StaffPassword", "");
                SqlTools.ExecuteNonQuery(comm);
                comm.Parameters.AddWithValue("@StaffId", Staff.GetStaffIdByName(staffNameBox.Text));
                SqlParameter p = new SqlParameter("@GroupId", "");
                comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                foreach (string o in GroupList)
                {
                    p.Value = Groups.GetGroupIdByName(o);
                    SqlTools.ExecuteNonQuery(comm);
                }
                Close();
            }
        }
    }
}
