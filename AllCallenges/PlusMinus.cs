using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges
{
    class PlusMinus
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr, n);

        }

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr, int length)
        {

            Console.WriteLine(Calculate(arr.Count(x => x > 0), length));
            Console.WriteLine(Calculate(arr.Count(x => x < 0), length));
            Console.WriteLine( Calculate(arr.Count(x => x == 0), length));
        }

        static decimal Calculate(int count, int length)
        {
            decimal result = (count > 0 && length > 0) ? ((decimal)count / length) : 0;
            return result;
        }
    }
}
