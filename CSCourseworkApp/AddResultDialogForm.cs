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
    public partial class AddResultDialogForm : Form
    {
        bool isAssignment;
        int groupId;
        BindingList<string> Students = new BindingList<string>();
        public AddResultDialogForm(BindingList<string> Students, int groupId, bool isAssignment)
        {
            InitializeComponent();
            this.isAssignment = isAssignment;
            this.groupId = groupId;
            this.Students = Students;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlParameter group = new SqlParameter("@GroupId", groupId);
            command.Parameters.Add(group);

            if (isAssignment)
            {
                command.CommandText = "INSERT INTO Homeworks VALUES (@HomeworkName, @GroupId)";
                command.Parameters.AddWithValue("@HomeworkName", assignmentNameTextBox.Text);
                SqlTools.ExecuteNonQuery(command);
            }
            else
            {
                command.CommandText = "INSERT INTO Tests VALUES (@TestName, @GroupId)";
                command.Parameters.AddWithValue("@TestName", assignmentNameTextBox.Text);
                SqlTools.ExecuteNonQuery(command);
            }
            EditResultsForm erf = new EditResultsForm(Students, groupId, isAssignment, assignmentNameTextBox.Text);
        }
    }
}
