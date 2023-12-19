using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllChallenges.HackerRank.BaseCodes
{
    public class CompareTheTriplets
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            if (a.Count == b.Count)
            {
                List<int> alice = new List<int>();
                List<int> bob = new List<int>();
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] != b[i])
                    {
                        if (a[i] > b[i])
                            alice.Add(1);
                        else
                            bob.Add(1);
                    }

                }
                result.Add(alice.Sum());
                result.Add(bob.Sum());
            }

            return result;

        }
        public static void Entry()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }


}
