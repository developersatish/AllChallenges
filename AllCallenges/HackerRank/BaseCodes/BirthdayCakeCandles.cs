using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AllChallenges.HackerRank.BaseCodes
{
    class BirthdayCakeCandles
    {
        public static void Entry()
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();

        }

        static int birthdayCakeCandles(int[] ar)
        {
            Console.WriteLine(ar);

            int longest = ar.OrderByDescending(x => x).Take(1).FirstOrDefault();

            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == longest)
                {

                    count++;
                    Console.WriteLine($"${longest} ${ar[i]} ${count}");
                }
            }

            return count;
        }
    }
}
