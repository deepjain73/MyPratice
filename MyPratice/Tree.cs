using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Tree
    {
        public Node root;

        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int d)
            {
                this.data = d;
                this.left = null;
                this.right = null;
            }
        }

        public void preorder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.data);
            preorder(root.left);
            preorder(root.right);
        }

        public void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.left);
            Console.WriteLine(root.data);
            Inorder(root.right);
        }

        public void postorder(Node root)
        {
            if (root == null)
                return;

            postorder(root.left);
            postorder(root.right);
            Console.WriteLine(root.data);
        }

        public void bfs(Node root, ArrayList al)
        {
            if (root == null)
                return;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count != 0)
            {
                Node d = q.Dequeue();
                Console.WriteLine(d.data);
                al.Add(d.data);

                if(d.left != null)
                {
                    q.Enqueue(d.left);
                }

                if (d.right != null)
                {
                    q.Enqueue(d.right);
                }
            }

            
        }
    }
}
