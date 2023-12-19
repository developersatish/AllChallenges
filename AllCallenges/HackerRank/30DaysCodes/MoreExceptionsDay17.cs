using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            double val = Math.Pow(Convert.ToDouble(n), Convert.ToDouble(p));
            return Convert.ToInt32(val);
        }
    }
    public class MoreExceptionsDay17
    {
        public static void Entry()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
