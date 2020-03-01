using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AllChallenges._30DaysCodes
{
    static class IntroToConditionalStatements
    {
        public static void Entry()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 0)
            {
                if (N >= 2 && N <= 5)
                {
                    WriteLine("Not Weird");
                }
                if (N >= 6 && N <= 20)
                {
                    WriteLine("Weird");
                }
                if (N > 20)
                {
                    WriteLine("Not Weird");
                }
            }
            else
            {
                WriteLine("Weird");
            }

        }
    }
}
