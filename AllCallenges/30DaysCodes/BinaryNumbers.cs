using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class BinaryNumbers
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // https://stackoverflow.com/questions/2954962/convert-integer-to-binary-in-c-sharp/2955001
            string result = Convert.ToString(Convert.ToInt32(Convert.ToString(n), 10), 2);
            Console.WriteLine(result);
            int j = 0, k = 0;
            string temp = "1";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].ToString() == temp)
                {
                    j++;
                }
                else
                {
                    j = 0;
                }
                if (k < j)
                {
                    k = j;
                }
               
            }
            Console.WriteLine(k);
        }
    }
}
