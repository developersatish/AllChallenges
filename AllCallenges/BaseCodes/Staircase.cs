using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges
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
            for (int i = 1; i <=n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }
    }
}
