using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPratice
{
    class LeftRightViewofBinaryTree
    {
        public Node root;
        public int currentlevel;

        public class Node
        {
            public int value;
            public Node left;
            public Node right;


            public Node(int v)
            {
                this.value = v;
                this.left = null;
                this.right = null;
                
            }
        }

        public void leftview(Node root, int level)
        {
            if(root == null)
            {
                return;
            }

            if(currentlevel < level)
            {
                Console.WriteLine(root.value);
                currentlevel = level;
            }

            leftview(root.left, level + 1);
            leftview(root.right, level + 1);
        }


        
        public void rightview(Node root,int level)
        {
            
            if (root == null)
            {
                return;
            }

            if (currentlevel < level)
            {
                Console.WriteLine(root.value);
                currentlevel = level;
            }

            rightview(root.right, level + 1);
            rightview(root.left, level + 1);
        }

    }
}
