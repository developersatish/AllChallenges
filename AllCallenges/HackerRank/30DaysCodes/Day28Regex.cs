using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-nested-logic/problem

    public class Day28Regex
    {
       
        public static void Entry()
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            var list = new List<string>();
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];

                if (Regex.IsMatch(emailID, @".+@gmail\.com$"))
                {
                    list.Add(firstName);
                }
            }

            list.Sort();
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
