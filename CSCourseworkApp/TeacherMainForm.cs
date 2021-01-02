using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class TeacherMainForm : Form
    {
        public TeacherMainForm()
        {
            InitializeComponent();
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            // Set teacher name
            teacherOverviewLabel.Text = $"Teacher Overview | {teacherOverviewLabel.Text}";
        }
    }
}
