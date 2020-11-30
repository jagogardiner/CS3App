using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSCourseworkApp
{
    class Groups
    {
        public static BindingList<string> GroupList;

        public static void PopulateList()
        {
            GroupList = new BindingList<string>();
            /*
             * populateList gets all the Groups
             * available in the database and adds them
             * to the List<string> GroupList.
             */
            DataTable dt = SqlTools.GetTable("SELECT GroupName FROM Groups");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                GroupList.Add(dt.Rows[i]["GroupName"].ToString());
            }
        }

        public static string GetAcademicYear(string groupName)
        {
            /*
             * getAcademicYear gets the academic year
             * assigned to a group and returns the join
             * result.
             * 
             * Arguments:
             * groupName (string): Name of the group to find the year of.
             */
            SqlCommand command = new SqlCommand("SELECT AcademicYears.AcademicYearName FROM Groups INNER JOIN AcademicYears ON Groups.AcademicYearId=AcademicYears.AcademicYearId WHERE Groups.GroupName = @GroupName");
            command.Parameters.AddWithValue("@GroupName", groupName);
            DataTable dt = SqlTools.GetTable(command);
            return dt.Rows[0]["AcademicYearName"].ToString();
        }

        public static string GetSubjectName(string groupName)
        {
            SqlCommand command = new SqlCommand("SELECT Subjects.SubjectName FROM Groups INNER JOIN Subjects ON Groups.SubjectId=Subjects.SubjectID WHERE Groups.GroupName = @GroupName");
            command.Parameters.AddWithValue("@GroupName", groupName);
            DataTable dt = SqlTools.GetTable(command);
            return dt.Rows[0]["SubjectName"].ToString();
        }

        public static int GetYearIdByName(string academicYearName)
        {
            /*
             * GetYearIdByName gets the AcademicYearId assigned to a
             * year name and returns the ID.
             * 
             * Arguments:
             * academicYearName (string): Name of the academic year.
             */
            SqlCommand command = new SqlCommand("SELECT AcademicYearId FROM AcademicYears WHERE AcademicYearName = @AcademicYearName");
            command.Parameters.AddWithValue("@AcademicYearName", academicYearName);
            DataTable dt = SqlTools.GetTable(command);
            return (int)dt.Rows[0]["AcademicYearId"];
        }

        public static int GetSubjectIdByName(string subjectName)
        {
            /*
             * GetSubjectIdByName gets the SubjectId assigned to a
             * subject name and returns the ID.
             * 
             * Arguments:
             * subjectName (string): Name of the subject.
             */
            SqlCommand command = new SqlCommand("SELECT SubjectId FROM Subjects WHERE SubjectName = @SubjectName");
            command.Parameters.AddWithValue("@SubjectName", subjectName);
            DataTable dt = SqlTools.GetTable(command);
            return (int)dt.Rows[0]["SubjectId"];
        }

        public static int GetGroupIdByName(string groupName)
        {
            /*
             * GetSubjectIdByName gets the SubjectId assigned to a
             * subject name and returns the ID.
             * 
             * Arguments:
             * subjectName (string): Name of the subject.
             */
            SqlCommand command = new SqlCommand("SELECT GroupId FROM Groups WHERE GroupName = @GroupName");
            command.Parameters.AddWithValue("@GroupName", groupName);
            DataTable dt = SqlTools.GetTable(command);
            return (int)dt.Rows[0]["GroupId"];
        }

        public static BindingList<string> GetStaff(string groupName)
        {
            /*
             * getStaff returns a List of strings of
             * the staff within group specified.
             * 
             * Arguments:
             * groupName (string): Name of the group to find the staff members of.
             */
            BindingList<string> staffList = new BindingList<string>();
            // Returns a table with the staff members at that GroupID using StaffGroupsLink table.
            SqlCommand command = new SqlCommand("SELECT Staff.StaffName FROM StaffGroupsLink INNER JOIN Staff ON StaffGroupsLink.StaffId=Staff.StaffId INNER JOIN Groups ON StaffGroupsLink.GroupId=Groups.GroupId WHERE Groups.GroupName = @GroupName");
            command.Parameters.AddWithValue("@GroupName", groupName);
            // Load the returned table into a new DataTable.
            // This is used to grab rows and avoid doing a lot of
            // sql querys which is time consuming.
            DataTable dt = SqlTools.GetTable(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                staffList.Add(dt.Rows[i]["StaffName"].ToString());
            }
            return staffList;
        }
    }
}
