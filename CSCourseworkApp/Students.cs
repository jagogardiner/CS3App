using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseworkApp
{
    class Students
    {
        public static BindingList<string> StudentList = new BindingList<string>();

        public static void PopulateList()
        {
            StudentList.Clear();
            DataTable dt = SqlTools.GetTable("SELECTS StudentName FROM Students");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                StudentList.Add((string)dt.Rows[i]["StudentName"]);
            }
        }

        public static void AddStudent(string studentName, string academicYearName)
        {

        }
    }
}
