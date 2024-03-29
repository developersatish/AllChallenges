﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    public class MyBook : Book
    {
        readonly String title;
        readonly String author;
        readonly int price;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public override void display()
        {
            Console.WriteLine($"Title: {this.title}\nAuthor: {this.author}\nPrice: {this.price}");
        }
    }
    public class AbstractClassesDay13
    {
        public static void Entry()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
