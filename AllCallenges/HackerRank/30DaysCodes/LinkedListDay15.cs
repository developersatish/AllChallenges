using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    public class LinkedListDay15
    {
        public static Node insert(Node head, int data)
        {
            Node current = head;
            if (current == null)
            {
                Node temp = new Node(data);
                return temp;
            }

            else
            {
                Node temp1 = current;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
                current = current.next;
                current.data = data;

                return temp1;
            }
        }

        public static void display(Node head)
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
            display(head);
        }
    }
}
