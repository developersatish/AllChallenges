using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges.HackerEarth
{
    public class Divisibility
    {
        public static void Go()
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

          
           string[] numbers = Console.ReadLine().Split(' ');

            string newNumber= numbers[numberOfTestCases - 1];

            string lastChar=newNumber.Substring(newNumber.Length - 1);
            Console.WriteLine(lastChar == "0"?"Yes":"No");
        }
    }
}
