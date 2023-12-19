using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
   public class ExceptionsStringToIntegerDay16
    {
        public static void Entry()
        {
            string S = Console.ReadLine();
            try
            {
                int val = Convert.ToInt32(S);
                Console.WriteLine(val);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
