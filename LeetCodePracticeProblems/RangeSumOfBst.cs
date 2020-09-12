using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LeetCodePracticeProblems
{
    class RangeSumOfBst
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

        public int RangeSumBST(Node root, int L, int R)
        {
            int result = 0;

            if (root == null)
            {
                return 0;
            }

            if (L <= root.value && root.value <= R)
            {
                result = result + root.value;
            }

            if (root.value < R)
            {
                result = result + RangeSumBST(root.right, L, R);
            }

            if (root.value > L)
            {
                result = result + RangeSumBST(root.left, L, R);
            }



            return result;
        }
    }
}

