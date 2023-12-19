using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AllChallenges.HackerRank.BaseCodes
{
    class GradingStudents
    {
        public static void Entry()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            // textWriter.WriteLine(String.Join("\n", result));

            // textWriter.Flush();
            //textWriter.Close();

        }

        static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach (int grade in grades)
            {
                int quation = grade % 5;
                int nextExpectedGrade = grade - quation + 5;
                int finalGrade = nextExpectedGrade - grade < 3 ? nextExpectedGrade : grade;
                result.Add(finalGrade >= 40 ? finalGrade : grade);

                Console.WriteLine($"{grade} - {quation} - {nextExpectedGrade}");
            }
            Console.WriteLine(string.Join("\n", result));
            return result;
        }
    }
}
