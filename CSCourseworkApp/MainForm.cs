using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Populate the group list on startup
            // and set the Data source of the group
            // list to it.
            InitializeComponent();
            Groups.PopulateList();
            Staff.PopulateList();
            groupsListBox.DataSource = Groups.GroupList;
            staffListBox.DataSource = Staff.StaffList;
        }

        private void HidePanels(Panel panelToShow)
        {
            // Hide all panels except admin selection panel and desired form passed as an arugment
            foreach (Panel panel in Controls.OfType<Panel>().Where(p => p != panelToShow && p != adminPanel))
            {
                panel.Hide();
            }
            panelToShow.Show();
        }

        private void ManageGroupsButton_Click(object sender, EventArgs e)
        {
            // Show Group panel
            HidePanels(manageGroupsPanel);
        }
        
        private void AdminStaffButton_Click(object sender, EventArgs e)
        {
            // Show Staff panel
            HidePanels(manageStaffPanel);
        }

        private void AdminStudentsButton_Click(object sender, EventArgs e)
        {
            // Show Students panel
            HidePanels(manageStudentsPanel);
        }

        private void GroupsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (groupsListBox.SelectedIndex != -1)
            {
                string groupName = groupsListBox.SelectedItem.ToString();
                int groupIndex = groupsListBox.SelectedIndex;
                // Make sure there isn't any index selected. This will panic otherwise.
                selectedGroupLabel.Text = Groups.GroupList[groupIndex];
                academicYearLabel.Text = $"Academic Year: {Groups.GetAcademicYear(groupName)}";
                // Seperate each lecturer by a line break, \r\n and join each staff.
                staffListLabel.Text = $"Assigned lecturer(s): {string.Join("\r\n", Groups.GetStaff(groupName))}";
                SubjectNameLabel.Text = $"Subject: {Subjects.GetSubjectName(groupName)}";
                // These buttons are hidden by default.
                editClassButton.Show();
                deleteClassButton.Show();
            }
        }

        private void EditClassButton_Click(object sender, EventArgs e)
        {
            // Deploy an edit form with the needed data.
            EditGroupForm editGroupForm = new EditGroupForm(Groups.GroupList[groupsListBox.SelectedIndex], groupsListBox.SelectedIndex + 1);
            editGroupForm.ShowDialog();
            Groups.PopulateList();
            // Simulate a value change to refresh changed data.
            GroupsListBox_SelectedValueChanged(this, e);
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            // Deploy an empty group edit form.
            EditGroupForm editGroupForm = new EditGroupForm();
            editGroupForm.ShowDialog();
            // Repopulate the list
            Groups.PopulateList();
            // Simulate a value change to refresh changed data.
            GroupsListBox_SelectedValueChanged(this, e);
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            // Create a simple MessageBox for admin confirmation.
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected group?",
                "Delete group",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            switch(dialogResult) {
                case DialogResult.Yes:
                    Groups.DeleteGroup(groupsListBox.SelectedItem.ToString());
                    break;
                default:
                    // Do nothing
                    break;
            }
        }

        private void editStaffInfoButton_Click(object sender, EventArgs e)
        {
            EditStaffForm edf = new EditStaffForm(staffListBox.SelectedItem.ToString());
            edf.ShowDialog();
            Staff.PopulateList();
            staffListBox_SelectedValueChanged(this, e);
        }

        private void staffListBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
