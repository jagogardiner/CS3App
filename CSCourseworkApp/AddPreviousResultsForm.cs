using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class AddPreviousResultsForm : Form
    {
        public int subjectId { get; set; }
        public AddPreviousResultsForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();

        private void AddPreviousResultsForm_Load(object sender, EventArgs e)
        {
            // Only add the subject ID once.
            command.CommandText = "SELECT * FROM PreviousResults WHERE SubjectId=@SubjectId";
            command.Parameters.AddWithValue("@SubjectId", subjectId);
            UpdateTable();
        }

        private void UpdateTable()
        {
            dt = SqlTools.GetTable(command);
            // Hide ID rows and add user friendly headers 
            PreviousResultView.DataSource = dt;
            PreviousResultView.Columns["ResultId"].Visible = false;
            PreviousResultView.Columns["SubjectId"].Visible = false;
            PreviousResultView.Columns["HomeworkResult"].HeaderText = "Homework grade average";
            PreviousResultView.Columns["TestResult"].HeaderText = "Test grade average";
            PreviousResultView.Columns["MTGResult"].HeaderText = "Minimum target grade";
            PreviousResultView.Columns["FinalResult"].HeaderText = "Final grade";
        }

        private void saveTable_Click(object sender, EventArgs e)
        {
            // Save the new results
            SqlTools.UpdateDatabaseFromTable(command, dt);
            // Refresh the table
            UpdateTable();
        }

        private void PreviousResultView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (PreviousResultView.CurrentRow != null)
            {
                PreviousResultView[PreviousResultView.Columns["SubjectId"].Index, PreviousResultView.CurrentRow.Index].Value = subjectId;
            }
        }
    }
}
