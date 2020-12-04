using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public enum PermissionLevel
    {
        TutorOverseer = 5,
        Overseer = 4,
        Admin = 3,
        Tutor = 2,
        Teacher = 1,
        None = 0
    };

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string HashingAlgorithm(string plain)
        {
            double val = 1;
            char[] plainarr = plain.ToCharArray();
            foreach(char ch in plainarr)
            {
                val += ch;
            }
            val = Math.Sin(val)*Math.Tan(val);
            string hash = val.ToString();
            hash = hash.Remove(0, 3);
            Debug.WriteLine(hash);
            return hash;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = HashingAlgorithm(passwordBox.Text);
            try
            {
                SqlCommand comm = new SqlCommand("SELECT StaffPassword FROM Staff WHERE StaffUsername = @StaffUsername");
                comm.Parameters.AddWithValue("@StaffUsername", username);
                DataTable dt = SqlTools.GetTable(comm);
                if((string)dt.Rows[0]["StaffPassword"] == password)
                {
                    switch (Staff.GetPermissionLevel(username))
                    {
                        case PermissionLevel.Admin:
                            AdminForm af = new AdminForm();
                            Hide();
                            af.FormClosed += (s, args) => Close();
                            af.Show();
                            break;
                        default:
                            MessageBox.Show("Future system will have lower permission levels");
                            break;
                    }
                }
                else
                {
                    invalidPasswordLabel.Show();
                }
            } 
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                invalidUsernameLabel.Show();
            }

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            invalidPasswordLabel.Hide();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            invalidPasswordLabel.Hide();
        }
    }
}
