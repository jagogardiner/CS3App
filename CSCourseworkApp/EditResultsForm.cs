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
            assignmentsBox.DataSource = AssignmentsList;
            studentsListBox.DataSource = StudentsList;
            PopulateList();
            foreach(KeyValuePair<string, double> grade in GradeUtils.Grades)
            {
                resultComboBox.Items.Add(grade.Key);
            }
            if (assignmentName != null)
            {
                assignmentId = GradeUtils.getAssignmentId(assignmentName, isHomework);
                assignmentsBox.SelectedItem = assignmentName;
            } else
            {
                assignmentId = GradeUtils.getAssignmentId((string)assignmentsBox.SelectedItem, isHomework);
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
            comm.Parameters.AddWithValue("@FinalGrade", GradeUtils.Grades[(string)resultComboBox.SelectedItem]);
            comm.Parameters.AddWithValue("@assignmentId", assignmentId);
            // ON DUPLICATE KEY UPDATE makes sure that if an assignment needs to be edited, it will update instead of inserting a new result.
            if (isHomework)
            {
                comm.CommandText = "INSERT INTO HomeworkResultsLink VALUES (@assignmentId, @StudentId, @FinalGrade)";
                SqlTools.ExecuteNonQuery(comm);
            } else
            {
                comm.CommandText = "INSERT INTO TestResults VALUES (@assignmentId, @StudentId, @FinalGrade) ON DUPLICATE KEY UPDATE FinalGrade=@FinalGrade";
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
            if(isHomework)
            {
                comm.CommandText = "SELECT FinalGrade FROM HomeworkResultsLink WHERE StudentId=@StudentId AND HomeworkId=@AssignmentId";
            } else
            {
                comm.CommandText = "SELECT FinalGrade FROM TestResults WHERE StudentId=@StudentId AND TestId=@AssignmentId";
            }
            try
            {
                double grade = (double)SqlTools.GetTable(comm).Rows[0]["FinalGrade"];
                string gradeKey = GradeUtils.Grades.FirstOrDefault(x => x.Value == grade).Key;
                resultComboBox.SelectedItem = gradeKey;
            }
            catch (Exception)
            {
                // There isn't a result for them yet.
            }
        }
    }
}
