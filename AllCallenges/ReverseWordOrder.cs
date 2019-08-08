using System;
using System.Collections.Generic;

namespace AllChallenges
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
            result = String.Join(" ", list.ToArray());

            Console.WriteLine(result);
        }
    }
}