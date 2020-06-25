using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class PostOrderDepthFirstTraversal
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

        public void postorder(Node n)
        {
            if (n == null)
            {
                Console.WriteLine("Tree is null");
            }

            if (n.left != null)
            {
                postorder(n.left);
            }

           
           if (n.right != null)
            {
                postorder(n.right);
            }

            Console.WriteLine(n.data);
        }
    }
}


// left -> Right -> Root