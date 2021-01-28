using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    /*
     * Permission level enumerator based off the int value
     * within the SQL table.
     */
    public enum PermissionLevel
    {
        TutorOverseer = 5, // Overseer & Tutor function
        Overseer = 4, // Teacher (assigned groups), Overseer (all data from all groups)
        Admin = 3, // Account & data management only - no class data, for data protection
        Tutor = 2, // Tutor can view data on all students within their tutor. Every Tutor is also a Teacher
        Teacher = 1, // Base level, can see group data that they are assigned to
        None = 0 // No permission
    };

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /*
         * Algorithm used for hashing passwords.
         * This could be reversed by any capable enough computer,
         * but it's more secure than storing passwords in plaintext.
         */
        public static string HashingAlgorithm(string plain)
        {
            double val = 1;
            // Convert plaintext password to a char array
            char[] plainarr = plain.ToCharArray();
            foreach(char ch in plainarr)
            {
                // Add each ASCII character value of each character to a total.
                val += ch;
            }
            /* 
             * To avoid allowing another character sum unlocking the same account,
             * add the 1st and last value of the character array to the sum.
             * This makes it very unlikely that two different passwords could
             * unlock the same account.
            */
            val += plainarr[0] + plainarr[plainarr.Length - 1];
            // Multiply the Sin of the value of by the Tan of the value.
            val = Math.Sin(val)*Math.Tan(val);
            // Store the double value into a string.
            string hash = val.ToString();
            // Remove the first three characters to make this less reversible.
            hash = hash.Remove(0, 3);
            Debug.WriteLine(hash);
            return hash;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Subjects.UpdateSubjectMLR("Mathematics");
            string username = usernameBox.Text;
            Debug.WriteLine(username);
            // Run plain-text password through algorithm
            //string password = HashingAlgorithm(passwordBox.Text);
            try
            {
                SqlCommand comm = new SqlCommand("SELECT StaffPassword FROM Staff WHERE StaffUsername = @StaffUsername");
                comm.Parameters.AddWithValue("@StaffUsername", username);
                DataTable dt = SqlTools.GetTable(comm);
                // If password needs to be reset, don't continue
                if((string)dt.Rows[0]["StaffPassword"] == "")
                {
                    ResetPasswordForm pwForm = new ResetPasswordForm(username);
                    pwForm.ShowDialog();
                    pwForm.Dispose();
                } else
                {
                    if (true/*(string)dt.Rows[0]["StaffPassword"] == password*/)
                    {
                        switch (Staff.GetPermissionLevel(username))
                        {
                            case PermissionLevel.TutorOverseer:
                                // TODO: Make all options available (prototype)
                                int staffId = Staff.GetStaffIdByUsername(username);
                                TeacherMainForm tf = new TeacherMainForm
                                {
                                    StaffId = staffId,
                                    StaffName = Staff.GetStaffNameById(staffId),
                                };
                                Hide();
                                tf.FormClosed += (s, args) => Close();
                                tf.Show();
                                break;
                            case PermissionLevel.Overseer:
                                break;
                            case PermissionLevel.Admin:
                                /*
                                AdminForm af = new AdminForm();
                                Hide();
                                af.FormClosed += (s, args) => Close();
                                af.Show();
                                */
                                break;
                            case PermissionLevel.Tutor:
                                break;
                            case PermissionLevel.Teacher:
                                /*
                                TeacherMainForm tf = new TeacherMainForm();
                                Hide();
                                tf.FormClosed += (s, args) => Close();
                                tf.Show();
                                */
                                break;
                            default:
                                MessageBox.Show("Future system will have lower permission levels");
                                break;
                        }
                    }
                    else
                    {
                        // The password must be wrong if the username is right.
                        invalidPasswordLabel.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                // Unfortunately, we have to assume the username is wrong.
                // The end-user can't have done much else wrong - except a bad
                // username.
                invalidUsernameLabel.Show();
            }

        }

        // If anything changes inside the username or password box 

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            invalidUsernameLabel.Hide();
            invalidPasswordLabel.Hide();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            invalidUsernameLabel.Hide();
            invalidPasswordLabel.Hide();
        }
    }
}
