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
    public partial class EditStudentForm : Form
    {
        public static BindingList<string> GroupList = new BindingList<string>();
        string studentName;

        public EditStudentForm(string studentName = null)
        {
            InitializeComponent();
            if(studentName != null)
            {
                this.studentName = studentName;
                studentNameTextBox.Text = studentName;
                studentIDTextBox.Text = Students.GetUsername(studentName);
                EditGroupForm.PopulateYears(academicYearComboBox, Students.GetAcademicYear(studentName));
                GroupList = Students.GetGroups(studentName);
            }
            else
            {
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
            AddStudentToGroupForm asgf = new AddStudentToGroupForm(GroupList);
            asgf.Show();
        }
    }
}
