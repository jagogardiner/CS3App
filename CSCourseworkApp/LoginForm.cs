using System;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        internal string hashingAlgorithm(string plain)
        {
            string[] indv = plain.Split();
            return null;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            using(SqlTools tools = new SqlTools())
            {
                tools.reader = tools.executeReader("SELECT PermissionId FROM Staff WHERE StaffUsername=" + username + "AND StaffPassword="+""); ;
            }
        }
    }
}
