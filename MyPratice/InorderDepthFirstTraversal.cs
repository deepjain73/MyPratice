using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class InorderDepthFirstTraversal
    {
        public class Node
        {
            public int data;
            public Node right;
            public Node left;

            public Node(int d)
            {
                data = d;
                left = null;
                right = null;
            }
        }

        public void inorder(Node n)
        {
            if (n == null)
            {
                return;
            }

                if(n.left != null)
                {
                    inorder(n.left);
                }

                Console.WriteLine(n.data);

                if (n.right != null)
                {
                    inorder(n.right);
                }
        }
    }
}


// Left -> Root -> Right

