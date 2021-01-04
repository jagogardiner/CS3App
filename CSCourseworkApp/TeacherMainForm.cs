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
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public TeacherMainForm()
        {
            InitializeComponent();
        }

        private void PopulateList()
        {
            teacherGroups.Clear();
            SqlCommand command = new SqlCommand("SELECT Groups.GroupName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE StaffGroupsLink.StaffId = @StaffId");
            command.Parameters.AddWithValue("@StaffId", StaffId);
            DataTable dt = SqlTools.GetTable(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Debug.WriteLine(dt.Rows[i]["GroupName"]);
                teacherGroups.Add((string)dt.Rows[i]["GroupName"]);
            }
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            // Set teacher name
            teacherOverviewLabel.Text = $"Teacher Overview | {StaffName}";
            PopulateList();
            teacherClassListBox.DataSource = teacherGroups;
        }

        private void teacherClassListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
