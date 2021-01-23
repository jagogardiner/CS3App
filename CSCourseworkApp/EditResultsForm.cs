using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditResultsForm : Form
    {
        bool isAssignment;
        int groupId;
        string assignmentName;
        BindingList<string> Assignments = new BindingList<string>();

        public EditResultsForm(int groupId, bool isAssignment = true, string assignmentName = null)
        {
            InitializeComponent();
            this.isAssignment = isAssignment;
            this.groupId = groupId;
            this.assignmentName = assignmentName;
            if(!isAssignment)
            {
                assignmentLabel.Text = "Test name:";
            }
            if(assignmentName != null)
            {
                assignmentsBox.SelectedItem = assignmentName;
            }
        }

        private void PopulateList()
        {
            if (isAssignment)
            {
                SqlCommand comm = new SqlCommand("SELECT HomeworkName FROM Homeworks WHERE GroupId=@GroupId");
                comm.Parameters.AddWithValue("@GroupId", groupId);
                DataTable dt = SqlTools.GetTable(comm);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Assignments.Add((string)dt.Rows[i]["HomeworkName"]);
                }
            }
            else
            {
                SqlCommand comm = new SqlCommand("SELECT TestName FROM Tests WHERE GroupId=@GroupId");
                comm.Parameters.AddWithValue("@GroupId", groupId);
                DataTable dt = SqlTools.GetTable(comm);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Assignments.Add((string)dt.Rows[i]["TestName"]);
                }
            }
        }

        private void EditResultsForm_Load(object sender, EventArgs e)
        {
            assignmentsBox.DataSource = Assignments;
            PopulateList();
        }
    }
}
