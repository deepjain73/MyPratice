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

        public IList<int> Postorder(Node root)
        {
            List<int> s = new List<int>();

            if (root == null)
            {
                return s;
            }
            

            Stack<Node> st = new Stack<Node>();
            st.Push(root);

            while (st.Count != 0)
            {
                root = st.Pop();
                s.Add(root.data);

                if (root.left != null)
                {
                    st.Push(root.left);
                }

               if(root.right != null)
                {
                    st.Push(root.right);
                }

                 Console.WriteLine(root.data);
            }

            return s;

        }
    }
}


// left -> Right -> Root