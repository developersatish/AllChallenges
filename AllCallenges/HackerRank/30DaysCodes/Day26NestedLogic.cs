using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-nested-logic/problem

    public class Day26NestedLogic
    {
       
        public static void Entry()
        {
            var actually = Console.ReadLine().Split(' ');
            var da = int.Parse(actually[0]);
            var ma = int.Parse(actually[1]);
            var ya = int.Parse(actually[2]);

            var expected = Console.ReadLine().Split(' ');
            var de = int.Parse(expected[0]);
            var me = int.Parse(expected[1]);
            var ye = int.Parse(expected[2]);

            var fine = 0;

            if (ya > ye) fine = 10000;
            else if (ya == ye)
            {
                if (ma > me) fine = (ma - me) * 500;
                else if (ma == me && da > de) fine = (da - de) * 15;
            }

            Console.WriteLine(fine);
        }
    }
}
