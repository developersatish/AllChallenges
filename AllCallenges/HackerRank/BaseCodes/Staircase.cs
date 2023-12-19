using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges.HackerRank.BaseCodes
{
    class Staircase
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);

        }

        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var spaces = new string(' ', n - i);
                var hashes = new string('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }
    }
}
