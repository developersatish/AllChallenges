﻿using AllChallenges._30DaysCodes;
using System;

namespace AllChallenges
{
    class Program
    {
        static void Entry()
        {
            Console.WriteLine("-----------------------Start > > > ------------------");
            // CompareTheTriplets.Entry();
            // AVeryBigSum.Entry();
            // DiagonalDifference.Entry2();
            // WINorLOSE.Entry();
            // Palindrom.Entry();
            // ReverseWordOrder.Sentences();
            // CodingQuestionAns.ReverseString("hello");
            // PlusMinus.Entry();
            // Staircase.Entry();
            // MinMaxSum.Entry();
            // BirthdayCakeCandles.Entry();
            // TimeConversion.Entry();
            // GradingStudents.Entry();
            // SockMerchant.Entry();
            // DataType.Entry();
            // Operators.Entry();
            // ClassVsInstance.Entry();
            // LetReview.Entry();
            // Arrays.Entry();
            // DictionariesAndMaps.Entry();
            // Recursion3.Entry();
            // BinaryNumbers.Entry();
            //Arrays2D.Entry();

            ArraySumToK.Entry();
        }
        static void Main(string[] args)
        {

            bool again = true;
            do
            {
                Entry();
                Console.WriteLine("Try again (y/n) !");
                again = Console.ReadLine() == "y";
            } while (again);
            Console.WriteLine("-----------------------End! ------------------");
        }
    }
}
