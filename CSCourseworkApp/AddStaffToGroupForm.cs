using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class AddStaffToGroupForm : Form
    {
        BindingList<string> availableGroups = Groups.GroupList;
        BindingList<string> staffGroups = EditStaffForm.GroupList;

        public AddStaffToGroupForm()
        {
            InitializeComponent();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void AddStaffToGroupForm_Load(object sender, EventArgs e)
        {
            foreach(string o in staffGroups)
            {
                availableGroups.Remove(o);
            }
            availableGroupsList.DataSource = availableGroups;
            selectedGroupsList.DataSource = staffGroups;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
