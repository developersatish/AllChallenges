using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Operators
    {
        public static void Entry()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);

        }

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            decimal tip = decimal.Parse(meal_cost.ToString("N1")) * Convert.ToDecimal(tip_percent / 100);
            decimal tax = decimal.Parse(meal_cost.ToString("N1")) * Convert.ToDecimal(tax_percent / 100);

            Console.WriteLine(Math.Round(total));
        }
    }
}
