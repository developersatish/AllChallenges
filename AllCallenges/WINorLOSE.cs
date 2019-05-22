using System;
using System.Collections.Generic;
using System.Text;

namespace AllCallenges
{
    class WINorLOSE
    {
        public static void Entry()
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Input
            Console.WriteLine("Number of test cases");
            int testCases = Convert.ToInt32(Console.ReadLine());

            int[] inputNVnP = new int[testCases];
            int[][] inputNoStr = new int[testCases][];
            int[][] inputNoEng = new int[testCases][];

            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine("No of Villans and Players");
                int noVillanPlayers = Convert.ToInt32(Console.ReadLine());
                inputNVnP[i] = noVillanPlayers;

                Console.WriteLine("Strengths of Villains");
                var strenghts = Console.ReadLine();
                string[] allStrenghts = strenghts.Trim().Split(' ');


                Console.WriteLine("Energy of Players");
                var energies = Console.ReadLine();
                string[] allEnergies = energies.Trim().Split(' ');


                int[] villansArray = new int[noVillanPlayers];
                villansArray = Array.ConvertAll(allStrenghts, arrTemp => Convert.ToInt32(arrTemp));
                Array.Sort(villansArray);
                inputNoStr[i] = villansArray;

                int[] playersArray = new int[noVillanPlayers];
                playersArray = Array.ConvertAll(allEnergies, arrTemp => Convert.ToInt32(arrTemp));
                Array.Sort(playersArray);
                inputNoEng[i] = playersArray;
            }


            //Output

            for (int i = 0; i < testCases; i++)
            {
                List<string> win = new List<string>();
                List<string> loss = new List<string>();
                if (inputNoStr[i].Length == inputNVnP[i] && inputNVnP[i] == inputNoEng[i].Length)
                {
                    for (int j = 0; j < inputNVnP[i]; j++)
                    {
                        if (inputNoEng[i][j] > inputNoStr[i][j])
                        {
                            win.Add("WIN");
                        }
                        else
                        {
                            loss.Add("LOSS");
                        }
                    }
                }


                Console.WriteLine(win.Count > loss.Count ? "WIN" : "LOSS");
            }




            Console.ReadLine();


        }
    }


}
