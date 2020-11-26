using System.Collections.Generic;
using System.Data;

namespace CSCourseworkApp
{
    class Groups
    {
        public static List<string> GroupList = new List<string>();
        public static DataTable groupDt = Datasets.CSDatabase.Tables["Groups"];

        public static void populateList()
        {
            foreach (DataRow dr in groupDt.Rows)
            {
                GroupList.Add(dr["GroupName"].ToString());
            }
        }
    }
}
