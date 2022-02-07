using System;
using System.IO;
using System.Linq;

/*
 Given a list of numbers nums and a number k, return whether any two numbers from the list add up to k. You may not use the same element twice.

Note: Numbers can be negative or 0.
Example 1

Input

nums = [35, 8, 18, 3, 22]
k = 11

Output

true
     */
namespace AllChallenges
{
    public class ArraySumToK
    {
        public static void Entry()
        {

            Console.WriteLine("Enter Array ");


            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            Console.WriteLine("Enter K Value ");
            int k = Convert.ToInt32(Console.ReadLine());


            bool result = Check(ar, k);


        }

        private static bool Check(int[] str, int k)
        {
            bool result = false;

            // str = str.Where(v => v <= k).ToArray();

            if (str.Length == 1)
            {
                return str[0] == k;
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && (str[i] + str[j]) == k)
                    {
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    break;
                }
            }

            return result;

        }
    }


}