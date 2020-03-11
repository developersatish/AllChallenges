using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class LetReview
    {
        public static void Entry()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> txt = new List<string>();
            for (int i = 0; i < n; i++)
            {
                txt.Add(Console.ReadLine());
            }

            
            foreach (string item in txt)
            {
                string even="",odd="";
                for (int j = 0; j < item.Length; j++)
                {
                    if(j%2==0){
                        even +=item[j];
                    }else{
                        odd +=item[j];
                    }
                }
                Console.WriteLine($"{even}  {odd}");
            }

        }
    }
}
