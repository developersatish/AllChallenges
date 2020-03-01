using System;

//Palindrom means if the word/sentence/pharase/numbers are similar in backword read.
namespace AllChallenges
{
    public class Palindrom
    {
        public static void Entry()
        {
            Console.WriteLine("Enter a word/sentence/pharases/number. ");
            string word = Console.ReadLine();
            CheckPalindrom(word);

        }

        private static void CheckPalindrom(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }

            Console.WriteLine(flag ? "Palindrom" : "Not a Palindrom");
        }
    }


}