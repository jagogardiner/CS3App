using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditGroupForm : Form
    {
        string groupName, academicYear;
        int groupIndex;
        bool newGroup;
        public EditGroupForm(string groupName, int groupIndex, bool newGroup)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.groupIndex = groupIndex;
            this.newGroup = newGroup;
        }

        public EditGroupForm(string groupName, int groupIndex, string academicYear)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.groupIndex = groupIndex;
            this.academicYear = academicYear;
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            groupNameTextBox.Text = groupName;
            populateYears();
        }
        
        private void populateYears()
        {
            using(SqlTools t = new SqlTools())
            {
                for(int i = 0; i < t.getRows("AcademicYears"); i++)
                {
                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@ID";
                    p.Value = i;
                    SqlCommand c = new SqlCommand("SELECT AcademicYearName FROM AcademicYears WHERE AcademicYearId = @ID");
                    c.Parameters.Add(p);
                    t.reader = t.executeReader(c);
                    while(t.reader.Read())
                    {
                        academYearComboBox.Items.Add(t.reader[0].ToString());
                    }
                }
            }
            if (!newGroup)
            {
                academYearComboBox.SelectedValue = academYearComboBox.FindStringExact(academicYear);
            }
        }
    }
}
