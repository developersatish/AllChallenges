using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges.HackerRank.BaseCodes
{
    class MinMaxSum
    {
        public static void Entry()
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);

        }

        // Complete the plusMinus function below.
        static void miniMaxSum(long[] arr)
        {
            long firstFour = arr.OrderBy(x => x).Take(4).Sum();
            long lastFour = arr.OrderByDescending(x => x).Take(4).Sum();
            Console.WriteLine(firstFour + " " + lastFour);
        }
    }
}
