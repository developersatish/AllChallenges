using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-linked-list-deletion/problem

    public class Day25RunningTimeandComplexity
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Entry()
        {
            var T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= 2 && isPrime(n)) Console.WriteLine("Prime");
                else Console.WriteLine("Not prime");
            }
        }
    }
}
