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
    public partial class ResetPasswordForm : Form
    {
        string username;
        public ResetPasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void savePasswordButton_Click(object sender, EventArgs e)
        {
            string password = pwBox.Text;
            if(password.Length > 0)
            {
                if (password == pwBoxConfirm.Text)
                {
                    SqlCommand comm = new SqlCommand("UPDATE Staff SET StaffPassword = @password WHERE StaffUsername = @StaffUsername");
                    comm.Parameters.AddWithValue("@password", LoginForm.HashingAlgorithm(password));
                    comm.Parameters.AddWithValue("@StaffUsername", username);
                    SqlTools.ExecuteNonQuery(comm);
                }
            } else
            {
                MessageBox.Show("Password cannot be empty!");
            }
            this.Close();
        }
    }
}
