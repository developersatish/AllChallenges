using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Loops
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
        }
    }
}
