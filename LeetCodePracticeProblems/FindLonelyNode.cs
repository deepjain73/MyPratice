using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace LeetCodePracticeProblems
{
    class FindLonelyNode
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int v)
            {
                this.value = v;
                this.right = null;
                this.left = null;
            }
        }

        public void findlonelynode(Node root)
        {
            if(root == null)
            {
                return;
            }

            if(root.left != null && root.right != null)
            {
                findlonelynode(root.left);
                findlonelynode(root.right);
            }

            else if(root.left != null)
            {
                Console.WriteLine(root.left.value);
                findlonelynode(root.left);

            }

            else if (root.right != null)
            {
                Console.WriteLine(root.right.value);
                findlonelynode(root.right);

            }
        }
    }
}
