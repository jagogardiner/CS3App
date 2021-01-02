using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace CSCourseworkApp
{
    class GradeUtils
    {
        // TODO: work out actual weights
        readonly Dictionary<string, double> Grades = new Dictionary<string, double>()
        {
            ["A*"] = 10.0,
            ["A"] = 8.0,
            ["B"] = 7.0,
            ["C"] = 6.0,
            ["D"] = 5.0,
            ["E"] = 3.5,
            ["U"] = 1.5
        };

        public static double[] calculateSubjectCoefficient(
            List<double> HomeworkResults,
            List<double> MockResults,
            List<double> MTGResults,
            List<double> FinalResults)
        {
            double[][] x = new double[HomeworkResults.Count][];
            // populate x
            for (int i = 0; i < HomeworkResults.Count; i++)
            {
                x[i] = new double[3];
            }
            double[] y = new double[FinalResults.Count];
            for (int i = 0; i < HomeworkResults.Count; i++)
            {
                x[i][0] = HomeworkResults[i];
                x[i][1] = MockResults[i];
                x[i][2] = MTGResults[i];
                y[i] = FinalResults[i];
            }
            return Fit.MultiDim(x, y, intercept: true);
        }

        double calculateGrade(double HomeworkGrade, double MockGrade, double MTG, double[] subjectCoefficient)
        {
            // TODO: remove just checking coeff values to make sure
            Debug.WriteLine(subjectCoefficient.Length);
            Debug.WriteLine(subjectCoefficient[0]);
            Debug.WriteLine(subjectCoefficient[1]);
            Debug.WriteLine(subjectCoefficient[2]);
            Debug.WriteLine(subjectCoefficient[3]);
            // using that y = algoritm, p[0] is always the constant
            double predict = subjectCoefficient[0] + subjectCoefficient[1] * HomeworkGrade + subjectCoefficient[2] * MockGrade + subjectCoefficient[3] * MTG;
            Debug.WriteLine(predict);
            return predict;
        }
    }
}
