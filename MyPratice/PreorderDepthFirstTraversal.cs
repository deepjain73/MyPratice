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


        public void preorder(Node n)
        {
            if (n == null)
            {
                Console.WriteLine("Tree is null");
            }

            Console.WriteLine(n.data);

            if (n.left != null)
            {
                preorder(n.left);
            }

            if (n.right != null)
            {
                preorder(n.right);
            }
        }


        public IList<int> Preorder(Node root)
        {
            List<int> s = new List<int>();

            if (root == null)
            {
                return s;
            }

            Stack<Node> st = new Stack<Node>();
            st.Push(root);

            while(st.Count != 0)
            {
                var p = st.Pop();
                Console.WriteLine(p.data);
                s.Add(p.data);

                if(p.right != null)
                {
                    st.Push(p.right);
                }

                if(p.left != null)
                {
                    st.Push(p.left);
                }
            }
            return s;
        }
    }
}


// Root -> Left -> Right
