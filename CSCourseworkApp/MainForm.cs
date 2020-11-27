using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            // show group management panel
            hidePanels(manageGroupsPanel);
            // populate group list
            Groups.populateList();
            foreach(string group in Groups.GroupList)
            {
                // add each item from group list into listbox
                groupsListBox.Items.Add(group);
            }
        }
        
        private void adminStaffButton_Click(object sender, EventArgs e)
        {
            hidePanels(manageStaffPanel);
        }

        private void adminStudentsButton_Click(object sender, EventArgs e)
        {

        }

        private void groupsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedGroupLabel.Text = Groups.GroupList[groupsListBox.SelectedIndex];
            academicYearLabel.Text = $"Academic Year: {Groups.getAcademicYear(groupsListBox.SelectedIndex)}";
            staffListLabel.Text = $"Assigned lecturer(s): {String.Join("\r\n", Groups.getStaff(groupsListBox.SelectedIndex))}";
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm(Groups.GroupList[groupsListBox.SelectedIndex], groupsListBox.SelectedIndex + 1, Groups.getAcademicYear(groupsListBox.SelectedIndex));
            editGroupForm.Show();
        }
    }
}
