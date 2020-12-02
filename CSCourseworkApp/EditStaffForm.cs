using System.ComponentModel;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditStaffForm : Form
    {
        string staffName;
        public static BindingList<string> GroupList = new BindingList<string>();
        public EditStaffForm(string staffName)
        {
            InitializeComponent();
            staffNameBox.Text = staffName;
            this.staffName = staffName;
            GroupList = Staff.GetGroups(staffName);
            // Get permission level, 3 being tutor, 4 being overseer.
            switch(Staff.GetPermissionLevel(staffName))
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
    }
}
