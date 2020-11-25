using System;
using System.Data;
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
            Debug.WriteLine(DumpDataTable(Groups.groupDt));
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
            //foreach(DataRow dr in Groups.groupDt.Rows)
            //{
            //    Debug.WriteLine(dr["AcademicYear"]);
            //}
        }

        public static string DumpDataTable(DataTable table)
        {
            string data = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (null != table && null != table.Rows)
            {
                foreach (DataRow dataRow in table.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        sb.Append(item);
                        sb.Append(',');
                    }
                    sb.AppendLine();
                }
                data = sb.ToString();
            }
            return data;
        }
    }
}
