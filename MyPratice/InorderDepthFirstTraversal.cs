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

            if (n.left != null)
            {
                inorder(n.left);
            }

            Console.WriteLine(n.data);

            if (n.right != null)
            {
                inorder(n.right);
            }
        }

        public IList<int> Inorder(Node root)
        {
            List<int> s = new List<int>();

            Stack<Node> st = new Stack<Node>();
            
            while (st.Count > 0 || root != null)
            {
                while(root != null)
                { 
                    st.Push(root);
                    root = root.left;
                }


                root = st.Pop();
                s.Add(root.data);
                Console.WriteLine(root.data);

                root = root.right;
            }

            return s;
        }
    }
}


// Left -> Root -> Right

