using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
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
            Debug.WriteLine(hash);
            hash = hash.Remove(0, 3);
            Debug.WriteLine(hash);
            return hash;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = HashingAlgorithm(passwordBox.Text);
            int permId = 0;
            permId = SqlTools.ExecuteScalar("Select PermissionLevel from Staff where StaffUsername='" + username + "' and StaffPassword='" + password + "'");
            switch (permId)
            {
                case 1:
                    MainForm af = new MainForm();
                    Hide();
                    af.FormClosed += (s, args) => Close();
                    af.Show();
                    break;
                default:
                    MessageBox.Show("Future system will have lower permission levels");
                    break;
            }
        }
    }
}
