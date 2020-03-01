using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AllChallenges
{
    class SockMerchant
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

        }

        static int sockMerchant(int n, int[] ar)
        {
            var q = ar.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);

            int result = 0;
            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count + " Pair: " + x.Count / 2);
                result += x.Count / 2;
            }

            Console.WriteLine(result);
            return result;
        }


    }
}
