using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseworkApp
{
    class Staff
    {
        public static int GetStaffIdByName(string staffName)
        {
            SqlCommand comm = new SqlCommand("SELECT StaffId FROM Staff WHERE StaffName = @StaffName");
            comm.Parameters.AddWithValue("@StaffName", staffName);
            DataTable dt = SqlTools.GetTable(comm);
            return (int)dt.Rows[0]["StaffId"];
        }
    }
}
