using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class ScopeDay14
    {
        public class Difference
        {
            private int[] elements;
            public int maximumDifference;

            public Difference(int[] ele)
            {
                this.elements = ele;
            }

            public void computeDifference()
            {
                int max = this.elements.Max();
                int min = this.elements.Min();
                this.maximumDifference = max - min;
            }
            // Add your code here

        }

        public static void Entry()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
