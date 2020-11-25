using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (Panel panel in Controls.OfType<Panel>().Where(p => p != panelToShow && p != this.adminPanel))
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

        }
    }
}
