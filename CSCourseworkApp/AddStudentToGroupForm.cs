using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            // Add grades into the combobox
            foreach (KeyValuePair<string, double> grade in GradeUtils.Grades)
            {
                mtgComboBox.Items.Add(grade.Key);
            }
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
                // Reset the minimum target grade box
                mtgComboBox.SelectedIndex = -1;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EditStudentForm.GroupList.Clear();
            foreach (string o in currentGroups)
            {
                EditStudentForm.GroupList.Add(o);
                // Lookup subject ID by group ID and the corresponding double to the grade.
                if (mtgComboBox.SelectedIndex != -1)
                {
                    try
                    {
                        EditStudentForm.minimumTargetGrades.Add(Groups.GetSubjectId(Groups.GetGroupIdByName(o)), (string)mtgComboBox.SelectedItem);
                    }
                    catch (Exception)
                    {
                        // They are in two duplicate groups. This doesn't really matter as it's not fatal,
                        // but check the user to see.
                        MessageBox.Show("Warning: There already exists a minimum target grade for this student in this subject. Have you added them to two groups of the same subject?", "Warning", MessageBoxButtons.OK);
                    }
                }
            }
            Close();
        }
    }
}
