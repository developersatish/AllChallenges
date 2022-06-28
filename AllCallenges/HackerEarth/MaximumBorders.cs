using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges.HackerEarth
{
    public class MaximumBorders
    {
        public static void Go()
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfTestCases; i++)

            {

                string[] table = (Console.ReadLine()).Split(" ");

                int rows = Convert.ToInt32(table[0]);

                int columns = Convert.ToInt32(table[1]);

                int max = 0;

                for (int j = 0; j < rows; j++)
                {
                    string[] blackCells = (Console.ReadLine()).Split('.');
                    int len = 0;

                    foreach (var item in blackCells)
                    {
                        if (len < item.Length)
                            len = item.Length;
                    }

                    if (max < len)
                    {
                        max = len;
                    }

                }

                Console.WriteLine(max);
            }
        }
    }
}
