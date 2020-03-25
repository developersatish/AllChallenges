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
            int j=0;
            string temp=string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                if(!String.IsNullOrEmpty(temp)){
                    temp=result[i].ToString();
                }                
                Console.WriteLine(result[i]);
            }
            //Console.WriteLine(result);
        }
    }
}
