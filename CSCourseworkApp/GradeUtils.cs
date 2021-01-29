using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CSCourseworkApp
{
    class GradeUtils
    {

        public struct GradeData
        {
            public double HwAverage;
            public double TestAverage;
            public double MTG;
            public double Predicted;
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

        // List of sorted doubles for grades, not for lookup usage
        public static List<double> GradeVals = Grades.Values.ToList();

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

        /*
         * Get the ID of any assignment - there are only two different types of assignment,
         * homeworks and tests, so just check if it's a homework or not 
         */
        public static int getAssignmentId(string assignmentName, bool isHomework)
        {
            SqlCommand comm = new SqlCommand();
            if (isHomework)
            {
                comm.CommandText = "SELECT HomeworkId FROM Homeworks WHERE HomeworkName=@HomeworkName";
                comm.Parameters.AddWithValue("@HomeworkName", assignmentName);
                DataTable dt = SqlTools.GetTable(comm);
                return (int)dt.Rows[0]["HomeworkId"];
            }
            else
            {
                comm.CommandText = "SELECT TestId FROM Tests WHERE TestName=@TestName";
                comm.Parameters.AddWithValue("@TestName", assignmentName);
                DataTable dt = SqlTools.GetTable(comm);
                return (int)dt.Rows[0]["TestId"];
            }
        }

        public static GradeData calculateStudentGrades(int studentId, int groupId)
        {
            double hwAverage = 0, testAverage = 0, mtg = 0;
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "SELECT FinalGrade FROM HomeworkResults ";
            comm.CommandText += "INNER JOIN Homeworks ON HomeworkResults.HomeworkId=Homeworks.HomeworkId ";
            comm.CommandText += "WHERE HomeworkResults.StudentId=@StudentId AND Homeworks.GroupId=@GroupId";
            comm.Parameters.AddWithValue("@StudentId", studentId);
            comm.Parameters.AddWithValue("@GroupId", groupId);
            // Get a table of all homework results.
            DataTable dt = SqlTools.GetTable(comm);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    hwAverage += (double)dt.Rows[i]["FinalGrade"];
                }
                hwAverage /= dt.Rows.Count;
                // Use LINQ to find the closest value to the divided average.
                hwAverage = GradeVals.Aggregate((x, y) => Math.Abs(x - hwAverage) < Math.Abs(y - hwAverage) ? x : y);
            }
            // Do the same with test results.
            comm.CommandText = "SELECT FinalGrade FROM TestResults ";
            comm.CommandText += "INNER JOIN Tests ON TestResults.TestId=Tests.TestId ";
            comm.CommandText += "WHERE TestResults.StudentId=@StudentId AND Tests.GroupId=@GroupId";
            dt = SqlTools.GetTable(comm);
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    testAverage += (double)dt.Rows[i]["FinalGrade"];
                }
                testAverage /= dt.Rows.Count;
                testAverage = GradeVals.Aggregate((x, y) => Math.Abs(x - testAverage) < Math.Abs(y - testAverage) ? x : y);
            }
            // Grab minimum target grade.
            // Get subject ID
            int subjectId = Groups.GetSubjectId(groupId);
            comm.CommandText = "SELECT Grade FROM MinimumTargetGrades WHERE SubjectId=@SubjectId AND StudentId=@StudentId";
            comm.Parameters.AddWithValue("@SubjectId", subjectId);
            dt = SqlTools.GetTable(comm);
            if (dt.Rows.Count != 0)
            {
                mtg = (double)dt.Rows[0]["Grade"];
            }
            // Work out their predicted grade based from this average data.
            double[] MLR = Subjects.GetSubjectMLR(subjectId);
            double predicted = calculateGrade(hwAverage, testAverage, mtg, MLR);
            predicted = GradeVals.Aggregate((x, y) => Math.Abs(x - predicted) < Math.Abs(y - predicted) ? x : y);
            return new GradeData
            {
                HwAverage = hwAverage,
                TestAverage = testAverage,
                MTG = mtg,
                Predicted = predicted
            };
        }
    }
}
