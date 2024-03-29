﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-binary-search-trees/tutorial
    public class Day22BinarySearchTrees
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static int getHeight(Node root)
        {
            //Write your code here
            if (root == null)
            {
                return -1;
            }

            int lh = getHeight(root.left);
            int rh = getHeight(root.right);

            if (lh > rh)
            {
                return lh + 1;
            }
            else
            {
                return rh + 1;
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static void Entry()
		{
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }
	}
}
