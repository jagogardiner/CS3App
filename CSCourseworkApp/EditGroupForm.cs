using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditGroupForm : Form
    {
        private readonly string groupName, academicYear;
        readonly bool newGroup;
        public EditGroupForm(string groupName, bool newGroup)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.newGroup = newGroup;
        }

        public EditGroupForm(string groupName, string academicYear)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.academicYear = academicYear;
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            groupNameTextBox.Text = groupName;
            PopulateYears();
        }
        
        private void PopulateYears()
        {
            DataTable dt = SqlTools.GetTable("SELECT AcademicYearName FROM AcademicYears");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                academYearComboBox.Items.Add(dt.Rows[i]["AcademicYearName"].ToString());
            }
            if (!newGroup)
            {
                academYearComboBox.SelectedIndex = academYearComboBox.FindStringExact(academicYear);
            }
        }
    }
}
