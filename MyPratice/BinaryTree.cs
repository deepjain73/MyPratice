using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    public class BinaryTree
    {

        public class Node
        {
            public int value;
            public Node right;
            public Node left;


            public Node(int v)
            {
                this.value = v;
                this.left = null;
                this.right = null;
            }
        }

        public int countNodes(Node root)
        {
            if (root == null)
                return 0;

            return 1 + countNodes(root.left) + countNodes(root.right);
        }
    }

}


