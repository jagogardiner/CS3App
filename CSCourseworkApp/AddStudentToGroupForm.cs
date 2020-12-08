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
    public partial class AddStudentToGroupForm : Form
    {
        BindingList<string> currentGroups = new BindingList<string>();
        BindingList<string> availableGroups = new BindingList<string>();

        public AddStudentToGroupForm()
        {
            InitializeComponent();
        }

        private void AddStudentToGroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
