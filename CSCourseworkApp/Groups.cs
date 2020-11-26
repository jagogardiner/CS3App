using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                p.Value = index+1;
                SqlCommand command = new SqlCommand("SELECT AcademicYears.AcademicYearName FROM Groups INNER JOIN AcademicYears ON Groups.AcademicYearId=AcademicYears.AcademicYearId WHERE Groups.GroupId = @ID");
                command.Parameters.Add(p);
                return t.getJoinResult(command);
            }
        }
    }
}
