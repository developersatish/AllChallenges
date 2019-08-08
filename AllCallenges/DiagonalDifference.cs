using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AllChallenges
{
    class DiagonalDifference
    {
        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int A = 0, B = 0;
            for (int i = 0; i < arr[0].Length; i++)
            {
                for (int j = 0; j < arr[1].Length; j++)
                {

                    if (i == j)
                    {
                        A = A + arr[i][j];
                    }
                   
                }

                int lastIndex = arr[1].Length - (i+1);
                B += arr[i][lastIndex];
            }

            return Math.Abs(A-B);
        }

       public static void Entry()
        {
          //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Enter Arr size");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            Console.WriteLine($"Result {result}");

           
        }

        public static void FindDublicates()
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Enter Arr size");
            int n = Convert.ToInt32(Console.ReadLine());

            

            var line = Console.ReadLine();
            string[] tokens = line.Split(' ');

            int[] array = new int[n];
            array = Array.ConvertAll(tokens, arrTemp => Convert.ToInt32(arrTemp));


            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();
            // Console.WriteLine($"Result {result}");

            Console.ReadLine();


        }

        public static void Entry2()
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Enter Arr size");
            int n = Convert.ToInt32(Console.ReadLine());



            var line = Console.ReadLine();
            string[] tokens = line.Split(' ');

            int[] array = new int[n];
            array = Array.ConvertAll(tokens, arrTemp => Convert.ToInt32(arrTemp));


            List<int> dict = new List<int> ();

            foreach (var value in array)
            {
                if (!dict.Contains(value))
                {
                    dict.Add(value);
                }                   
                
            }

            List<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (!dict.Contains(i))
                {
                    result.Add(i);
                }
            }

            result.Sort();

           
            Console.WriteLine($"Result {string.Join(" ",result.ToArray())}");

            Console.ReadLine();


        }
    }
}
