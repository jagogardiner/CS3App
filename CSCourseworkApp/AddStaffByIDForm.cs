using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class AddStaffByIDForm : Form
    {
        bool validID = false;
        string staffName;

        public AddStaffByIDForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (validID)
            {
                EditGroupForm f = new EditGroupForm();
                f.AddNewLecturer(staffName);
                f.Close();
                this.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT StaffName FROM Staff WHERE StaffUsername = @StaffID");
            comm.Parameters.AddWithValue("@StaffID", staffIDTextBox.Text);
            try
            {
                DataTable dt = SqlTools.GetTable(comm);
                staffNameLabel.Text = $"Name: { dt.Rows[0]["StaffName"]}";
                staffName = dt.Rows[0]["StaffName"].ToString();
                validID = true;
            }
            catch
            {
                // Do nothing. SQL will fail if the ID is incorrect but no operation
                // needs to be made.
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
