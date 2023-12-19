﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class InheritanceDay12
    {
        public static void Entry()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        public class Person
        {
            protected string firstName;
            protected string lastName;
            protected int id;

            public Person() { }
            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.id = identification;
            }
            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }

        public class Student : Person
        {
            private int[] testScores;

            /*	
            *   Class Constructor
            *   
            *   Parameters: 
            *   firstName - A string denoting the Person's first name.
            *   lastName - A string denoting the Person's last name.
            *   id - An integer denoting the Person's ID number.
            *   scores - An array of integers denoting the Person's test scores.
            */
            // Write your constructor here
            protected int[] scores;
            public Student()
            {

            }
            public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
            {
                this.scores = scores;
            }

            public char Calculate()
            {
                char grade = 'T';
                int marks = 0;
                for (int i = 0; i < scores.Length; i++)
                {
                    marks += scores[i];
                }

                marks = marks / scores.Length;

                if (marks >= 90 && marks <= 100)
                    grade = 'O';
                else if (marks >= 80 && marks < 90)
                    grade = 'E';
                else if (marks >= 70 && marks < 80)
                    grade = 'A';
                else if (marks >= 55 && marks < 70)
                    grade = 'P';
                else if (marks >= 40 && marks < 55)
                    grade = 'D';

                return grade;
            }
            /*	
            *   Method Name: Calculate
            *   Return: A character denoting the grade.
            */
            // Write your method here
        }
    }
}
