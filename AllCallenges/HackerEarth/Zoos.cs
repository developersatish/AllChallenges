using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllChallenges.HackerEarth
{
    public class Zoos
    {
        public static void Go()
        {
            string name = Console.ReadLine();                  // Reading input from STDIN

            char[] chars = name.ToLower().ToCharArray();
            int noOfZs = chars.Count(x => x == 'z');
            int noOfOs = chars.Count(x => x == 'o');
            Console.WriteLine(noOfOs == noOfZs * 2 ? "Yes" : "No");
        }
    }
}
