using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class TeacherMainForm : Form
    {
        public static BindingList<string> teacherGroups = new BindingList<string>();
        public static BindingList<string> studentsList = new BindingList<string>();
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        int GroupId = 0;
        public TeacherMainForm()
        {
            InitializeComponent();
        }

        private void PopulateGroupList()
        {
            teacherGroups.Clear();
            SqlCommand command = new SqlCommand("SELECT Groups.GroupName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE StaffGroupsLink.StaffId = @StaffId");
            command.Parameters.AddWithValue("@StaffId", StaffId);
            DataTable dt = SqlTools.GetTable(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                teacherGroups.Add((string)dt.Rows[i]["GroupName"]);
            }
        }

        private void PopulateStudentsList(int GroupId)
        {
            studentsList.Clear();
            SqlCommand command = new SqlCommand("SELECT StudentName FROM StudentGroupsLink INNER JOIN Students ON StudentGroupsLink.StudentId=Students.StudentId WHERE StudentGroupsLink.GroupId=@GroupId");
            command.Parameters.AddWithValue("@GroupId", GroupId);
            DataTable dt = SqlTools.GetTable(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                studentsList.Add((string)dt.Rows[i]["StudentName"]);
            }
        }


        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            // Set teacher name
            teacherOverviewLabel.Text = $"Teacher Overview | {StaffName}";
            PopulateGroupList();
            teacherClassListBox.DataSource = teacherGroups;
            StudentsListBox.DataSource = studentsList;
            Subjects.UpdateSubjectMLR(1);
        }

        private void teacherClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupId = Groups.GetGroupIdByName(teacherClassListBox.SelectedItem.ToString());
            if (teacherClassListBox.SelectedIndex != -1)
            {
                PopulateStudentsList(GroupId);
            }
        }

        private void addAssignmentButton_Click(object sender, EventArgs e)
        {
        }

        private void editAssignmentsButton_Click(object sender, EventArgs e)
        {
            EditResultsForm erf = new EditResultsForm(studentsList, GroupId, true);
            erf.Show();
        }
    }
}
