using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace MyPratice
{
    class FindDeepestNode
    {
        public class Node
        {
            public char value;
            public Node right;
            public Node left;

            public Node(char v)
            {
                this.value = v;
                this.right = null;
                this.left = null;
            }

        }


        public void deepestNode(Node root)
        {
            int countA = 0,countB = 0;

           if(root == null)
            {
                return;
            }

            while(root.left != null)
            {
                root = root.left;
                countA++;
            }


            while(root.right != null)
            {
                root = root.right;
                countB++;
            }

            if(countA > countB)
            {
                Console.WriteLine(root.value);
            }

            else
            {
                Console.WriteLine(root.value);
            }

        }
    }
}






//Given the root of a binary tree, return a deepest node. For example, in the following tree, return d.
//      a
//     / \
//    b   c
//   /
//  d
