using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    public partial class EditStaffForm : Form
    {
        string staffName;

        public EditStaffForm(string staffName)
        {
            InitializeComponent();
            this.staffName = staffName;
            groupsListBox.DataSource = Staff.GetGroups(staffName);
        }
    }
}
