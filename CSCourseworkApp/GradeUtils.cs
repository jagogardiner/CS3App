using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using MathNet.Numerics;
using System.Data;
using System.Linq;

namespace CSCourseworkApp
{
    class GradeUtils
    {

        public struct GradeData
        {
            public double[] hw;
            public double[] tests;
            public double mtg;
            public double predicted;
        }

        public static Dictionary<string, double> Grades = new Dictionary<string, double>()
        {
            /*
             * These are based somewhat off of the GCSE 9-1/A-U
             * comparisons. C is known as 4/5 depending on the pass,
             * so I decided to split the difference.
             * U has some weight as it is extremely unlikely a student
             * will get 0%.
             * 
             * This is just my interpretation - this can be adjusted freely.
             */
            ["A*"] = 9.0,
            ["A"] = 7.0,
            ["B"] = 6.0,
            ["C"] = 4.5,
            ["D"] = 3.5,
            ["E"] = 2.0,
            ["U"] = 0.5
        };

        /*
         * calculateSubjectMLR returns a multiple linear
         * regression line based off of previous results and performance
         * in a specific subject.
         * 
         * In the database, there are previous results and their according
         * homework, test and minimum target grade grades.
         * This algorithm feeds them all in and does a multiple linear
         * regression calculation.
         * 
         * This is then used later in calculateGrade to make a grade prediciton.
         */
        public static double[] calculateSubjectMLR(
            List<double> HomeworkResults,
            List<double> TestResults,
            List<double> MTGResults,
            List<double> FinalResults)
        {
            // Create a jagged array, performanceGrades, with the homework, test and mtg grades.
            double[][] performanceGrades = new double[HomeworkResults.Count][];
            // populate x - jagged arrays don't like being uninitalised.
            for (int i = 0; i < HomeworkResults.Count; i++)
            {
                performanceGrades[i] = new double[3];
            }
            // Array finalGrades is just the resulting final grades.
            double[] finalGrades = new double[FinalResults.Count];
            // Populate these arrays with the input of grades and their according final result.
            for (int i = 0; i < HomeworkResults.Count; i++)
            {
                performanceGrades[i][0] = HomeworkResults[i];
                performanceGrades[i][1] = TestResults[i];
                performanceGrades[i][2] = MTGResults[i];
                finalGrades[i] = FinalResults[i];
            }
            // Return the multilinear regression line.
            return Fit.MultiDim(performanceGrades, finalGrades, intercept: true);
        }

        /*
         * calculateGrade is responsible for interpreting a
         * predicted grade based off of current homework, test
         * and minimum target grade results, using the subject's 
         * previous results and performance in each element.
         * 
         * subjectMLRLine is the result of a multiple linear regression
         * calculation, calculated in calculateSubjectCoefficient().
         * 
         * subjectMLRLine: c + x[1] + x[2] + x[3]
         * c: y-intercept of the line, constant term
         * x[1]: Slope coefficient for homework performance.
         * x[2]: Slope coefficient for test performance.
         * x[3]: Slope coefficient for minimum target grade.
         * 
         * A slope coefficient may also be known as the "weight" each
         * variable carries.
         * 
         * We then multiply these weights against our results, add
         * them together, and we have a predicited final result.
         */
        public static double calculateGrade(double HomeworkGrade, double TestGrade, double MTG, double[] subjectMLRLine) 
            => subjectMLRLine[0] // Constant
                + subjectMLRLine[1] * HomeworkGrade // Homework performance weight calculation
                + subjectMLRLine[2] * TestGrade // Test grade performance weight calculation
                + subjectMLRLine[3] * MTG; // Minimum target grade weight calculation.

        public static GradeData pullStudentGrades(int studentId, int groupId)
        {
            GradeData gd;
            // grab homeworks
            SqlCommand comm = new SqlCommand("SELECT HomeworkId FROM Homeworks WHERE GroupId=@GroupId");
            comm.Parameters.AddWithValue("@GroupId", groupId);
            DataTable homeworkIds = SqlTools.GetTable(comm);
            // define parameter outside for loop.
            SqlParameter hwId = new SqlParameter("@HomeworkId", null);
            comm.Parameters.AddWithValue("@StudentId", studentId);
            comm.Parameters.Add(hwId);
            // define array of homework grades
            double[] hwGrades = new double[homeworkIds.Rows.Count];
            for (int i = 1; i <= homeworkIds.Rows.Count; i++)
            {
                comm.CommandText = "SELECT FinalGrade FROM HomeworkResultsLink WHERE HomeworkId=@HomeworkId AND StudentId=@StudentId";
                hwId.Value = i;
                DataTable num = SqlTools.GetTable(comm);
                hwGrades[i - 1] = (double)num.Rows[0]["FinalGrade"];
            }
            // place new array in gradedata struct
            gd.hw = hwGrades;

            // grab tests
            comm.CommandText = "SELECT TestId FROM Tests WHERE GroupId=@GroupId";
            comm.Parameters.AddWithValue("@GroupId", groupId);
            DataTable testIds = SqlTools.GetTable(comm);
            // define parameter outside for loop.
            SqlParameter testId = new SqlParameter("@HomeworkId", null);
            comm.Parameters.AddWithValue("@StudentId", studentId);
            comm.Parameters.Add(hwId);
            // define array of homework grades
            double[] testGrades = new double[testIds.Rows.Count];
            for (int i = 1; i <= testIds.Rows.Count; i++)
            {
                comm.CommandText = "SELECT FinalGrade FROM TestResults WHERE TestId=@TestId AND StudentId=@StudentId";
                testId.Value = i;
                DataTable num = SqlTools.GetTable(comm);
                testGrades[i - 1] = (double)num.Rows[0]["FinalGrade"];
            }
            gd.tests = testGrades;

            gd.mtg = 0;
            gd.predicted = 0;
            return gd;
        }
    }
}
