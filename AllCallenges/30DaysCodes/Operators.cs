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


            decimal meal = (decimal)meal_cost;

            decimal tipPer = (decimal)tip_percent / 100;
            decimal tip = meal  * tipPer;

            decimal taxPer = (decimal)tax_percent / 100;
            decimal tax = meal * taxPer;

            var total = meal + tip + tax;

            Console.WriteLine(Math.Round(total));
        }
    }
}
