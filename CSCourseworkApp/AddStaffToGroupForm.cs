using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class AddStaffToGroupForm : Form
    {
        BindingList<string> availableGroups = new BindingList<string>();
        BindingList<string> staffGroups = new BindingList<string>();

        public AddStaffToGroupForm()
        {
            InitializeComponent();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            if (availableGroupsList.SelectedIndex != -1)
            {
                staffGroups.Add(availableGroups[availableGroupsList.SelectedIndex]);
                availableGroups.RemoveAt(availableGroupsList.SelectedIndex);
            }
        }

        private void AddStaffToGroupForm_Load(object sender, EventArgs e)
        {
            foreach (string o in Groups.GroupList)
            {
                availableGroups.Add(o);
            }
            foreach (string o in EditStaffForm.GroupList)
            {
                staffGroups.Add(o);
            }
            foreach (string o in staffGroups)
            {
                availableGroups.Remove(o);
            }
            availableGroupsList.DataSource = availableGroups;
            selectedGroupsList.DataSource = staffGroups;

        }

        private void delGroupButton_Click(object sender, EventArgs e)
        {
            if (selectedGroupsList.SelectedIndex != -1)
            {
                availableGroups.Add(staffGroups[selectedGroupsList.SelectedIndex]);
                staffGroups.RemoveAt(selectedGroupsList.SelectedIndex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EditStaffForm.GroupList.Clear();
            foreach (string o in staffGroups)
            {
                EditStaffForm.GroupList.Add(o);
            }
            Close();
        }
    }
}
