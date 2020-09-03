using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPratice
{
    class SerializeDeserailizeABinaryTree
    {
        public Node root;
        public class Node
        {
            public int data;
            public Node right;
            public Node left;

            public Node(int d)
            {
                this.data = d;
                this.left = null;
                this.right = null;
            }
        }

        public void serialize(Node root)
        {
            if(root == null)
            {
                return;
            }

            int[] a = new int[] { };

            a.Append(root.data);
            serialize(root.left);
            serialize(root.right);

            
        }
    }
}
