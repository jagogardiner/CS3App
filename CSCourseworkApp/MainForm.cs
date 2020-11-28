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
            InitializeComponent();
            Groups.PopulateList();
            foreach (string group in Groups.GroupList)
            {
                // add each item from group list into listbox
                groupsListBox.Items.Add(group);
            }
        }

        private void HidePanels(Panel panelToShow)
        {
            // hide all panels except admin selection panel and desired form passed as an arugment
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
            selectedGroupLabel.Text = Groups.GroupList[groupsListBox.SelectedIndex];
            academicYearLabel.Text = $"Academic Year: {Groups.GetAcademicYear(groupsListBox.SelectedItem.ToString())}";
            // Seperate each lecturer by a line break, \r\n and join each staff.
            staffListLabel.Text = $"Assigned lecturer(s): {string.Join("\r\n", Groups.GetStaff(groupsListBox.SelectedItem.ToString()))}";
        }

        private void EditClassButton_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm(Groups.GroupList[groupsListBox.SelectedIndex], Groups.GetAcademicYear(groupsListBox.SelectedItem.ToString()));
            editGroupForm.Show();
        }
    }
}
