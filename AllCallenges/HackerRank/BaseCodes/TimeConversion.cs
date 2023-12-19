using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AllChallenges.HackerRank.BaseCodes
{
    class TimeConversion
    {
        public static void Entry()
        {
            // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            // tw.WriteLine(result);

            // tw.Flush();
            // tw.Close();

        }

        static string timeConversion(string s)
        {
            string time = "";
            DateTime dt;
            bool res = DateTime.TryParse(s, out dt);

            time = dt.ToString("HH:mm:ss");
            Console.WriteLine(time);
            return time;

        }
    }
}
