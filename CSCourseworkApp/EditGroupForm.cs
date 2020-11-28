using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditGroupForm : Form
    {
        string academicYear;
        bool newGroup;
        List<string> staffList = new List<string>();

        public EditGroupForm()
        {
            InitializeComponent();
            newGroup = true;
            groupTitleLabel.Text = "New Group";
            saveGroupButton.Text = "Add new group";
        }

        public EditGroupForm(string groupName, string academicYear, List<string> staffList)
        {
            InitializeComponent();
            this.academicYear = academicYear;
            this.staffList = staffList;
            groupNameTextBox.Text = groupName;
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            PopulateYears();
            foreach (string o in staffList)
            {
                Debug.WriteLine(o);
            }
            lecturerBox.DataSource = staffList;
        }
        
        private void PopulateYears()
        {
            DataTable dt = SqlTools.GetTable("SELECT AcademicYearName FROM AcademicYears");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                academicYearComboBox.Items.Add(dt.Rows[i]["AcademicYearName"].ToString());
            }
            if (!newGroup)
            {
                academicYearComboBox.SelectedIndex = academicYearComboBox.FindStringExact(academicYear);
            }
        }

        public void AddNewLecturer(string staffName)
        {
            staffList.Add(staffName);
            foreach(string o in staffList)
            {
                Debug.WriteLine(o);
            }
            lecturerBox.Update();
        }

        private void AddStaffIDButton_Click(object sender, EventArgs e)
        {
            AddStaffByIDForm addStaff = new AddStaffByIDForm();
            addStaff.ShowDialog();
        }

        private void SaveGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveStaffButton_Click(object sender, EventArgs e)
        {
            if(lecturerBox.SelectedIndex != -1)
            {
                staffList.Remove(lecturerBox.SelectedItem.ToString());
                lecturerBox.Items.Remove(lecturerBox.SelectedItem);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
