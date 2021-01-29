using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class OverseerForm : Form
    {
        public int StaffId { get; set; }
        public bool isTutor { get; set; }
        public OverseerForm()
        {
            InitializeComponent();
        }

        private void teachingFunctionsButton_Click(object sender, System.EventArgs e)
        {
            // Make a new teaching form.
            TeacherMainForm tf = new TeacherMainForm
            {
                StaffId = this.StaffId,
                StaffName = Staff.GetStaffNameById(this.StaffId),
            };
            Hide();
            tf.ShowDialog();
            tf.Dispose();
            Show();
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            // Just free memory and close. This is the end form.
            Close();
            Dispose();
            Application.Exit();
        }

        private void adminButton_Click(object sender, System.EventArgs e)
        {
            AdminForm af = new AdminForm();
            Hide();
            af.ShowDialog();
            Show();
        }

        private void OverseerForm_Load(object sender, System.EventArgs e)
        {
            if (!isTutor)
            {
                tutorButton.Hide();
            }
        }
    }
}
