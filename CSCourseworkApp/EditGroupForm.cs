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

        public EditGroupForm(string groupName, int groupId)
        {
            /*
             * Used for editing an existing group.
             */
            InitializeComponent();
            academicYear = Groups.GetAcademicYear(groupName);
            staffList = Groups.GetStaff(groupName);
            Subject = Subjects.GetSubjectName(groupName);
            this.groupId = groupId;
            groupNameTextBox.Text = groupName;
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            // Populate the available years, including the pre-existing academic year
            PopulateYears(academicYearComboBox, academicYear);
            // Populate the subject box
            PopulateSubjects();
            // Set the listbox datasource to the binding staff list
            lecturerBox.DataSource = staffList;
        }

        public static void PopulateYears(ComboBox cb, string academicYear = null)
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
                cb.Items.Add(dt.Rows[i]["AcademicYearName"].ToString());
            }
            if (academicYear != null)
            {
                cb.SelectedIndex = cb.FindStringExact(academicYear);
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
            /*
             * Add a staff member via their ID.
             * Pop up a new form to do this.
             */
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
            /*
             * SaveButton executes the SQL query needed for inserting
             * a new Group and its related staff members.
             * newGroup defines whether a group is being edited or
             * a new group is being created.
             */
            if (!newGroup)
            {
                // Delete all cases of the group beforehand to avoid conflicts.
                SqlCommand comm = new SqlCommand("DELETE FROM StaffGroupsLink WHERE GroupId = @GroupId");
                comm.Parameters.AddWithValue("@GroupId", groupId);
                SqlTools.ExecuteNonQuery(comm);
                SqlParameter staffId = new SqlParameter("@StaffId", "");
                // Insert the new group-staff links with the selected staff
                comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                comm.Parameters.Add(staffId);
                foreach (string o in staffList)
                {
                    // Loop over each Staff ID in the list.
                    staffId.Value =  Staff.GetStaffIdByName(o);
                    SqlTools.ExecuteNonQuery(comm);
                }
                // Update with the new subject if changed
                comm.CommandText = "UPDATE Groups SET SubjectId = @SubjectId WHERE GroupId = @GroupId";
                comm.Parameters.AddWithValue("@SubjectId", Subjects.GetSubjectIdByName(subjectsComboBox.SelectedItem.ToString()));
                SqlTools.ExecuteNonQuery(comm);
                // Update with the new Academic Year if changed
                comm.CommandText = "UPDATE Groups SET AcademicYearId = @AcademicYearId WHERE GroupId = @GroupId";
                comm.Parameters.AddWithValue("@AcademicYearId", Groups.GetYearIdByName(academicYearComboBox.SelectedItem.ToString()));
                SqlTools.ExecuteNonQuery(comm);
                // Repopulate the list with the new group.
                AdminForm.RefreshLists();
                Close();
            }
            else
            {
                // New group
                if(groupNameTextBox.Text != "" && academicYearComboBox.SelectedIndex != -1 && subjectsComboBox.SelectedIndex != -1 && lecturerBox.Items.Count != 0)
                {
                    // Insert the parameters into the query.
                    SqlCommand comm = new SqlCommand("INSERT INTO Groups (GroupName, SubjectId, AcademicYearId) VALUES (@GroupName, @SubjectId, @AcademicYearId)");
                    comm.Parameters.AddWithValue("@GroupName", groupNameTextBox.Text);
                    comm.Parameters.AddWithValue("@SubjectId", Subjects.GetSubjectIdByName(subjectsComboBox.SelectedItem.ToString()));
                    comm.Parameters.AddWithValue("@AcademicYearId", Groups.GetYearIdByName(academicYearComboBox.SelectedItem.ToString()));
                    SqlTools.ExecuteNonQuery(comm);
                    SqlParameter StaffId = new SqlParameter("@StaffId", "");
                    comm.Parameters.Add(StaffId);
                    // Get the newly created group ID
                    comm.Parameters.AddWithValue("@GroupId", Groups.GetGroupIdByName(groupNameTextBox.Text));
                    comm.CommandText = "INSERT INTO StaffGroupsLink (GroupId, StaffId) VALUES (@GroupId, @StaffId)";
                    foreach (string o in lecturerBox.Items)
                    {
                        // Loop through the staff ID's and add them
                        StaffId.Value = Staff.GetStaffIdByName(o);
                        SqlTools.ExecuteNonQuery(comm);
                    }
                    AdminForm.RefreshLists();
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
            // Make sure we have a cancel button
            Close();
        }
    }
}
