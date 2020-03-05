using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges._30DaysCodes
{
    public class Arrays
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            string msg="";

            for (int i = (arr.Length-1); i >= 0; i--)
            {
                Console.WriteLine($"{i} {arr[i]}");
                msg+=" "+arr[i];
            }
            Console.WriteLine(msg.Trim());
        }
    }
}
