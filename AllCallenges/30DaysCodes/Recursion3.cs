using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Recursion3
    {
        static int res = 1;
        static int factorial(int n)
        {

            if (n > 1)
            {
                res *= n * factorial(n - 1);               
            }


            return res;

        }

        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
            Console.WriteLine(result);
        }
    }
}
