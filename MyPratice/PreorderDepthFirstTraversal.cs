using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    //Preorder 

    class PreorderDepthFirstTraversal
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

       
        public void preorder( Node n)
        {
            if(n == null)
            {
               Console.WriteLine("Tree is null");
            }

            Console.WriteLine(n.data);

            if(n.left != null)
            {
                preorder(n.left);
            }

            if(n.right != null)
            {
                preorder(n.right);
            }
        }
    }
}


// Root -> Left -> Right
