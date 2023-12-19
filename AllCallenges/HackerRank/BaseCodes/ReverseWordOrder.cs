using System;
using System.Collections.Generic;

namespace AllChallenges.HackerRank.BaseCodes
{
    public class ReverseWordOrder
    {
        public static void Sentences()
        {
            Console.WriteLine("Write a word");

            string world = Console.ReadLine();

            string[] arr = world.Split(" ");

            List<string> list = new List<string>();
            string result = string.Empty;

            foreach (var item in arr)
            {
                list.Add(item);
            }
            list.Reverse();
            result = string.Join(" ", list.ToArray());

            Console.WriteLine(result);
        }
    }
}