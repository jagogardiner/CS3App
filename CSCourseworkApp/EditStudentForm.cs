using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditStudentForm : Form
    {
        public static BindingList<string> GroupList = new BindingList<string>();
        public static Dictionary<int, string> minimumTargetGrades = new Dictionary<int, string>();

        int studentId;
        bool newStudent = false;

        public EditStudentForm(string studentName = null)
        {
            InitializeComponent();
            if (studentName != null)
            {
                studentId = Students.GetStudentIdByName(studentName);
                studentNameTextBox.Text = studentName;
                studentIDTextBox.Text = Students.GetUsername(studentName);
                EditGroupForm.PopulateYears(academicYearComboBox, Students.GetAcademicYear(studentName));
                GroupList = Students.GetGroups(studentName);
            }
            else
            {
                newStudent = true;
                editStudentTitleLabel.Text = "Add new student";
                EditGroupForm.PopulateYears(academicYearComboBox);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            GroupListBox.DataSource = GroupList;
        }

        private void editGroupsButton_Click(object sender, EventArgs e)
        {
            AddStudentToGroupForm asgf = new AddStudentToGroupForm();
            asgf.ShowDialog();
            asgf.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!newStudent)
            {
                // Edit student details with the existing ID
                Students.EditStudent(studentNameTextBox.Text, studentIDTextBox.Text, academicYearComboBox.SelectedIndex + 1, GroupList, out studentId, studentId);
            }
            else
            {
                // Add new student, don't provide an ID as this will be generated.
                // Set the student ID to the one returned.
                Students.EditStudent(studentNameTextBox.Text, studentIDTextBox.Text, academicYearComboBox.SelectedIndex + 1, GroupList, out studentId);
            }
            // Finally, update the student's minimum target grades.
            Students.UpdateMTGs(studentId, minimumTargetGrades);
            Close();
        }
    }
}
