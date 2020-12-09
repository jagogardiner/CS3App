using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class AddStudentToGroupForm : Form
    {
        BindingList<string> currentGroups = new BindingList<string>();
        BindingList<string> availableGroups = new BindingList<string>();

        public AddStudentToGroupForm()
        {
            InitializeComponent();
        }

        private void AddStudentToGroupForm_Load(object sender, EventArgs e)
        {
            foreach (string o in Groups.GroupList)
            {
                availableGroups.Add(o);
            }
            foreach (string o in EditStudentForm.GroupList)
            {
                currentGroups.Add(o);
            }
            foreach (string o in currentGroups)
            {
                availableGroups.Remove(o);
            }
            availableGroupsListBox.DataSource = availableGroups;
            currentGroupsListBox.DataSource = currentGroups;
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            if (currentGroupsListBox.SelectedIndex != -1)
            {
                availableGroups.Add(currentGroups[currentGroupsListBox.SelectedIndex]);
                currentGroups.RemoveAt(currentGroupsListBox.SelectedIndex);
            }
        }

        private void addToGroupsButton_Click(object sender, EventArgs e)
        {
            if (availableGroupsListBox.SelectedIndex != -1)
            {
                currentGroups.Add(availableGroups[availableGroupsListBox.SelectedIndex]);
                availableGroups.RemoveAt(availableGroupsListBox.SelectedIndex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EditStudentForm.GroupList.Clear();
            foreach (string o in currentGroups)
            {
                EditStudentForm.GroupList.Add(o);
            }
            Close();
        }
    }
}
