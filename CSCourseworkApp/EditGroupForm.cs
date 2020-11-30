using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditGroupForm : Form
    {
        string academicYear, Subject;
        bool newGroup;
        public static string staffName;
        int groupId;
        BindingList<string> staffList = new BindingList<string>();

        public EditGroupForm()
        {
            /*
             * Called for a new group, so modify
             * labels as needed.
             */
            InitializeComponent();
            newGroup = true;
            groupTitleLabel.Text = "New Group";
            saveGroupButton.Text = "Add new group";
        }

        public EditGroupForm(string groupName, string academicYear, string Subject, BindingList<string> staffList, int groupId)
        {
            /*
             * Used for editing an existing group.
             */
            InitializeComponent();
            this.academicYear = academicYear;
            this.staffList = staffList;
            this.groupId = groupId;
            this.Subject = Subject;
            groupNameTextBox.Text = groupName;
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            PopulateYears();
            PopulateSubjects();
            lecturerBox.DataSource = staffList;
        }
        
        private void PopulateYears()
        {
            /*
             * Fill the combo box with all the available years
             * that can be assigned to a group. 
             * If the group is pre-existing, make sure it is
             * preselected.
             */
            DataTable dt = SqlTools.GetTable("SELECT AcademicYearName FROM AcademicYears");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                academicYearComboBox.Items.Add(dt.Rows[i]["AcademicYearName"].ToString());
            }
            if (!newGroup)
            {
                academicYearComboBox.SelectedIndex = academicYearComboBox.FindStringExact(academicYear);
            }
        }

        private void PopulateSubjects()
        {
            /*
             * Fill the combo box with all the subjects
             * that can be assigned to a group.
             * If the group is pre-existing, make sure
             * it is preselected.
             */
            DataTable dt = SqlTools.GetTable("SELECT SubjectName FROM Subjects");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                subjectsComboBox.Items.Add(dt.Rows[i]["SubjectName"].ToString());
            }
            if(!newGroup)
            {
                subjectsComboBox.SelectedIndex = subjectsComboBox.FindStringExact(Subject);
            }
        }

        private void AddStaffIDButton_Click(object sender, EventArgs e)
        {
            AddStaffByIDForm addStaff = new AddStaffByIDForm();
            addStaff.ShowDialog();
            if(staffName != null)
            {
                staffList.Add(staffName);
                staffName = null;
            }
        }

        private void SaveGroupButton_Click(object sender, EventArgs e)
        {
            if (!newGroup)
            {
                SqlCommand comm = new SqlCommand("DELETE FROM StaffGroupsLink WHERE GroupId = @GroupId");
                comm.Parameters.AddWithValue("@GroupId", groupId);
                SqlTools.ExecuteNonQuery(comm);
                SqlParameter staffId = new SqlParameter("@StaffId", "");
                comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                comm.Parameters.Add(staffId);
                foreach (string o in staffList)
                {
                    staffId.Value =  Staff.GetStaffIdByName(o);
                    SqlTools.ExecuteNonQuery(comm);
                }
                comm.CommandText = "UPDATE Groups SET SubjectId = @SubjectId WHERE GroupId = @GroupId";
                comm.Parameters.AddWithValue("@SubjectId", Groups.GetSubjectIdByName(subjectsComboBox.SelectedItem.ToString()));
                SqlTools.ExecuteNonQuery(comm);
                comm.CommandText = "UPDATE Groups SET AcademicYearId = @AcademicYearId WHERE GroupId = @GroupId";
                comm.Parameters.AddWithValue("@AcademicYearId", Groups.GetYearIdByName(academicYearComboBox.SelectedItem.ToString()));
                SqlTools.ExecuteNonQuery(comm);
                Close();
            }
            else
            {
                if(groupNameTextBox.Text != "" && academicYearComboBox.SelectedIndex != -1 && subjectsComboBox.SelectedIndex != -1 && lecturerBox.Items.Count != 0)
                {
                    SqlCommand comm = new SqlCommand("INSERT INTO Groups (GroupName, SubjectId, AcademicYearId) VALUES (@GroupName, @SubjectId, @AcademicYearId)");
                    comm.Parameters.AddWithValue("@GroupName", groupNameTextBox.Text);
                    comm.Parameters.AddWithValue("@SubjectId", Groups.GetSubjectIdByName(subjectsComboBox.SelectedItem.ToString()));
                    comm.Parameters.AddWithValue("@AcademicYearId", Groups.GetYearIdByName(academicYearComboBox.SelectedItem.ToString()));
                    SqlTools.ExecuteNonQuery(comm);
                    SqlParameter StaffId = new SqlParameter("@StaffId", "");
                    comm.Parameters.Add(StaffId);
                    comm.Parameters.AddWithValue("@GroupId", Groups.GetGroupIdByName(groupNameTextBox.Text));
                    foreach (string o in lecturerBox.Items)
                    {
                        StaffId.Value = o;
                        comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                    }
                    Debug.WriteLine("Written new subject");
                    Close();
                }
            }
        }

        private void RemoveStaffButton_Click(object sender, EventArgs e)
        {
            if(lecturerBox.SelectedIndex != -1)
            {
                staffList.RemoveAt(lecturerBox.SelectedIndex);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
