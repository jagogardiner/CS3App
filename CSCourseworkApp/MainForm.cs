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
            Groups.populateList();
            foreach (string group in Groups.GroupList)
            {
                // add each item from group list into listbox
                groupsListBox.Items.Add(group);
            }
        }

        private void hidePanels(Panel panelToShow)
        {
            // hide all panels except admin selection panel and desired form passed as an arugment
            foreach (Panel panel in Controls.OfType<Panel>().Where(p => p != panelToShow && p != adminPanel))
            {
                panel.Hide();
            }
            panelToShow.Show();
        }

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            // Show Group panel
            hidePanels(manageGroupsPanel);
        }
        
        private void adminStaffButton_Click(object sender, EventArgs e)
        {
            // Show Staff panel
            hidePanels(manageStaffPanel);
        }

        private void adminStudentsButton_Click(object sender, EventArgs e)
        {
            // Show Students panel
            hidePanels(manageStudentsPanel);
        }

        private void groupsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedGroupLabel.Text = Groups.GroupList[groupsListBox.SelectedIndex];
            academicYearLabel.Text = $"Academic Year: {Groups.getAcademicYear(groupsListBox.SelectedItem.ToString())}";
            // Seperate each lecturer by a line break, \r\n and join each staff.
            staffListLabel.Text = $"Assigned lecturer(s): {string.Join("\r\n", Groups.getStaff(groupsListBox.SelectedItem.ToString()))}";
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm(Groups.GroupList[groupsListBox.SelectedIndex], Groups.getAcademicYear(groupsListBox.SelectedItem.ToString()));
            editGroupForm.Show();
        }
    }
}
