using System;
using System.Collections.Generic;
using System.Text;

namespace AllChallenges._30DaysCodes
{

    //https://www.hackerrank.com/challenges/30-binary-trees/tutorial

    public class Day23BSTLevelOrderTraversal
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

        static void levelOrder(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node curr = queue.Dequeue();
                Console.Write(curr.data + " ");

                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
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
            levelOrder(root);
        }
	}
}
