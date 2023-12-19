using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllChallenges._30DaysCodes
{
    public class DictionariesAndMaps
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Array.ConvertAll(Console.ReadLine().Split(' '), arr => arr);
                phoneBook.Add(data[0], data[1]);
            }


            for (int i = 0; i < n; i++)
            {
                string find = Console.ReadLine();
                if (!String.IsNullOrEmpty(find) && phoneBook.ContainsKey(find))
                {
                    Console.WriteLine($"{find}={phoneBook[find]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
