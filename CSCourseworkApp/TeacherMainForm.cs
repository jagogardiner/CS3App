﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static CSCourseworkApp.GradeUtils;

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
            for (int i = 0; i < dt.Rows.Count; i++)
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
            for (int i = 0; i < dt.Rows.Count; i++)
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
            if (teacherClassListBox.SelectedIndex != -1)
            {
                GroupId = Groups.GetGroupIdByName(teacherClassListBox.SelectedItem.ToString());
                PopulateStudentsList(GroupId);
                StudentsListBox.SelectedIndex = -1;
            }
        }

        private void addAssignmentButton_Click(object sender, EventArgs e)
        {
            AddResultDialogForm ardf = new AddResultDialogForm(studentsList, GroupId, true);
            ardf.ShowDialog();
            ardf.Dispose();
        }

        private void editAssignmentsButton_Click(object sender, EventArgs e)
        {
            EditResultsForm erf = new EditResultsForm(studentsList, GroupId, true);
            erf.ShowDialog();
            erf.Dispose();
        }

        private void addTestResultButton_Click(object sender, EventArgs e)
        {
            AddResultDialogForm ardf = new AddResultDialogForm(studentsList, GroupId, false);
            ardf.ShowDialog();
            ardf.Dispose();
        }

        private void editTestResultsButton_Click(object sender, EventArgs e)
        {
            EditResultsForm erf = new EditResultsForm(studentsList, GroupId, false);
            erf.ShowDialog();
            erf.Dispose();
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load average and predicted for the selected student.
            if (StudentsListBox.Items.Count != 0)
            {
                // Reset labels
                homeworkAverageLabel.Text = "--";
                testsAverageLabel.Text = "--";
                mtgLabel.Text = "--";
                predictedGradeLabel.Text = "--";
                if (StudentsListBox.SelectedIndex != -1)
                {
                    // Grab data.
                    GradeData Data = GradeUtils.calculateStudentGrades(StudentsListBox.SelectedIndex + 1, GroupId);
                    // Only bother showing new data if they have homework and test results.
                    if(Data.HwAverage != 0 && Data.TestAverage != 0 && Data.MTG != 0)
                    {
                        homeworkAverageLabel.Text = Grades.FirstOrDefault(k => k.Value == Data.HwAverage).Key;
                        testsAverageLabel.Text = Grades.FirstOrDefault(k => k.Value == Data.TestAverage).Key;
                        mtgLabel.Text = Grades.FirstOrDefault(k => k.Value == Data.MTG).Key;
                        predictedGradeLabel.Text = Grades.FirstOrDefault(k => k.Value == Data.Predicted).Key;
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
