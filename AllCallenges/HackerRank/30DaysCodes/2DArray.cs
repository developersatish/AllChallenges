using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class _2DArray
    {
        public static void Entry()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int row = arr.GetLength(0);          

            int max_sum = int.MinValue;
            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < row - 2; j++)
                {
                    // Considering mat[i][j] as top
                    // left cell of hour glass.
                    int sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]) +
                        (arr[i + 1][j + 1]) +
                              (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]);

                    // If previous sum is less then
                    // current sum then update
                    // new sum in max_sum
                    max_sum = Math.Max(max_sum, sum);
                }
            }

            Console.WriteLine(max_sum);
        }
    }
}
