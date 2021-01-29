using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditResultsForm : Form
    {
        bool isHomework;
        int groupId;
        string assignmentName;
        int assignmentId;
        BindingList<string> AssignmentsList = new BindingList<string>();
        BindingList<string> StudentsList = new BindingList<string>();

        public EditResultsForm(BindingList<string> StudentsList, int groupId, bool isHomework = true, string assignmentName = null)
        {
            InitializeComponent();
            this.isHomework = isHomework;
            this.groupId = groupId;
            this.assignmentName = assignmentName;
            this.StudentsList = StudentsList;
        }

        private void PopulateList()
        {
            SqlCommand comm = new SqlCommand();
            if (isHomework)
            {
                comm.CommandText = "SELECT HomeworkName FROM Homeworks WHERE GroupId=@GroupId";
                comm.Parameters.AddWithValue("@GroupId", groupId);
                DataTable dt = SqlTools.GetTable(comm);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AssignmentsList.Add((string)dt.Rows[i]["HomeworkName"]);
                }
            }
            else
            {
                comm.CommandText = "SELECT TestName FROM Tests WHERE GroupId=@GroupId";
                comm.Parameters.AddWithValue("@GroupId", groupId);
                DataTable dt = SqlTools.GetTable(comm);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AssignmentsList.Add((string)dt.Rows[i]["TestName"]);
                }
            }
        }

        private void EditResultsForm_Load(object sender, EventArgs e)
        {
            // Populate list of assignments
            PopulateList();
            // Assign the boxes their datasources
            assignmentsBox.DataSource = AssignmentsList;
            studentsListBox.DataSource = StudentsList;
            // Add grades into the combobox
            foreach (KeyValuePair<string, double> grade in GradeUtils.Grades)
            {
                resultsComboBox.Items.Add(grade.Key);
            }
            // If assignment is provided, select the assignment that was just created.
            if (assignmentName != null)
            {
                assignmentId = GradeUtils.getAssignmentId(assignmentName, isHomework);
                assignmentsBox.SelectedItem = assignmentName;
            }
            else
            {
                try
                {
                    // Encase in try to stop errors if there are no assignments
                    assignmentId = GradeUtils.getAssignmentId((string)assignmentsBox.SelectedItem, isHomework);
                }
                catch (Exception)
                {
                    // No assignment exists.
                }
            }
            if (!isHomework)
            {
                assignmentLabel.Text = "Test name:";
            }
        }

        private void saveResultButton_Click(object sender, EventArgs e)
        {
            /*
             * Insert result into results table
             */
            SqlCommand comm = new SqlCommand();
            comm.Parameters.AddWithValue("@StudentId", Students.GetStudentIdByName(studentsListBox.SelectedItem.ToString()));
            comm.Parameters.AddWithValue("@FinalGrade", (string)resultsComboBox.SelectedItem);
            comm.Parameters.AddWithValue("@AssignmentId", assignmentId);
            // Update the result, however if the affected rowcount is 0, insert a new result as there is nothing to update.
            if (isHomework)
            {
                comm.CommandText = "UPDATE HomeworkResults SET FinalGrade=@FinalGrade WHERE StudentId=@StudentId AND HomeworkId=@AssignmentId ";
                comm.CommandText += "IF @@ROWCOUNT = 0 INSERT INTO HomeworkResults VALUES (@assignmentId, @StudentId, @FinalGrade)";
                SqlTools.ExecuteNonQuery(comm);
            }
            else
            {
                comm.CommandText = "UPDATE TestResults SET FinalGrade=@FinalGrade WHERE StudentId=@StudentId AND TestId=@AssignmentId ";
                comm.CommandText += "IF @@ROWCOUNT = 0 INSERT INTO TestResults VALUES (@assignmentId, @StudentId, @FinalGrade)";
                SqlTools.ExecuteNonQuery(comm);
            }
        }

        private void assignmentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignmentName = assignmentsBox.SelectedItem.ToString();
            assignmentId = GradeUtils.getAssignmentId(assignmentName, isHomework);
        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.Parameters.AddWithValue("@StudentId", Students.GetStudentIdByName(studentsListBox.SelectedItem.ToString()));
            comm.Parameters.AddWithValue("@AssignmentId", assignmentId);
            if (isHomework)
            {
                comm.CommandText = "SELECT FinalGrade FROM HomeworkResults WHERE StudentId=@StudentId AND HomeworkId=@AssignmentId";
            }
            else
            {
                comm.CommandText = "SELECT FinalGrade FROM TestResults WHERE StudentId=@StudentId AND TestId=@AssignmentId";
            }
            try
            {
                string grade = (string)SqlTools.GetTable(comm).Rows[0]["FinalGrade"];
                resultsComboBox.SelectedItem = grade;
            }
            catch (Exception)
            {
                // There isn't a result for them yet.
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
