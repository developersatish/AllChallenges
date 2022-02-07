using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Arrays2D
    {
        public static void Entry()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine("\b");
                    string res = "";
                    for (int p = 0; p < 3; p++)
                    {
                        res += arr[i][j].ToString() + " ";
                    }
                    Console.WriteLine(res);
                }
                
            }
        }
    }
}
