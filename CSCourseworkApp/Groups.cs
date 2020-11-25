using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCourseworkApp
{
    class Groups
    {
        public static List<string> GroupList = new List<string>();
        public static DataTable groupDt = new DataTable();

        public static void populateList()
        {
            using (SqlTools t = new SqlTools())
            {
                groupDt = t.populateDataTable("Groups");
            }
            foreach (DataRow dr in groupDt.Rows)
            {
                GroupList.Add(dr["GroupName"].ToString());
            }
        }
    }
}
