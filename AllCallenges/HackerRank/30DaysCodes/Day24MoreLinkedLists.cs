using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-linked-list-deletion/problem

    public class Day24MoreLinkedLists
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }

        static Node removeDuplicates(Node head)
        {
            var cr = head;
            while (cr != null && cr.next != null)
            {
                while (cr.next != null && cr.data == cr.next.data)
                {
                    cr.next = cr.next.next;
                }
                cr = cr.next;
            }

            return head;
        }

        static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static void Entry()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
