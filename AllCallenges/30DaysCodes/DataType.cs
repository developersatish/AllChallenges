using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Console;

namespace AllChallenges._30DaysCodes
{
    public class DataType
    {
        public static void Entry()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int SI = Convert.ToInt32(Console.ReadLine());
            double SD = Convert.ToDouble(Console.ReadLine());
            string SS = Console.ReadLine();

            Console.WriteLine(i + SI);

            var _decimal = Math.Round(Convert.ToDecimal(d) + Convert.ToDecimal(SD), 1).ToString("N1");



            //Math.Round(Convert.ToDecimal(d) + Convert.ToDecimal(SD), 1);

            Console.WriteLine(_decimal);

            Console.WriteLine(s + SS);

        }
    }
}
