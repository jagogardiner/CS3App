using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSCourseworkApp
{
    class Groups
    {
        public static List<string> GroupList = new List<string>();

        public static void populateList()
        {
            using (SqlTools t = new SqlTools())
            {
                for (int i = 1; i <= t.getRows("Groups"); i++)
                {
                    SqlCommand comm = new SqlCommand("SELECT GroupName FROM Groups where GroupId = @ID");
                    SqlParameter ID = new SqlParameter();
                    ID.ParameterName = "@ID";
                    ID.Value = i;
                    comm.Parameters.Add(ID);
                    t.reader = t.executeReader(comm);
                    while (t.reader.Read())
                    {
                        GroupList.Add(t.reader[0].ToString());
                    }
                }
            }
        }

        public static string getAcademicYear(int index)
        {
            using(SqlTools t = new SqlTools())
            {
                SqlParameter p = new SqlParameter();
                p.ParameterName = "@ID";
                p.Value = index + 1;
                SqlCommand command = new SqlCommand("SELECT AcademicYears.AcademicYearName FROM Groups INNER JOIN AcademicYears ON Groups.AcademicYearId=AcademicYears.AcademicYearId WHERE Groups.GroupId = @ID");
                command.Parameters.Add(p);
                return t.getJoinResult(command);
            }
        }

        public static List<string> getStaff(int index)
        {
            List<string> staffList = new List<string>();
            using(SqlTools t = new SqlTools())
            {
                SqlCommand command = new SqlCommand("SELECT Staff.StaffName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE Groups.GroupId = @ID");
                SqlParameter id = new SqlParameter();
                id.ParameterName = "@ID";
                id.Value = index + 1;
                command.Parameters.Add(id);
                t.reader = t.executeReader(command);
                DataTable dt = new DataTable();
                dt.Load(t.reader);
                t.reader = t.executeReader(command);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    while (t.reader.Read())
                    {
                        staffList.Add(t.reader[i].ToString());
                    }
                }
            }
            return staffList;
        }
    }
}
