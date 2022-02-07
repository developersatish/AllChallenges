using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
   public class Day21Generics
    {
	

		public static void Entry()
        {
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			PrintArray<String>(stringArray);
		}

        private static void PrintArray<T>(T[] stringArray)
        {
            foreach (T item in stringArray)
            {
				Console.WriteLine(item);
            }
        }
    }
}
