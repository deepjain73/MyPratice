using System;
using System.Collections;
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

        public void breadthfirstsearch(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
            }

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            

            while(q.Count > 0)
            {
                var n = q.Dequeue();
                

                if (n.left != null)
                {
                    q.Enqueue(n.left);
                }

                if(n.right != null)
                {
                    q.Enqueue(n.right);
                }

                Console.WriteLine(n.value);
            }
        }

        public Node SearchTree(Node root, int key)
        {
            if (root == null)
                return null;
            if (root.value == key)
                return root;
            if (key < root.value)
                return SearchTree(root.left, key);
            else
                return SearchTree(root.right, key);
        }

        public bool binarytreesearch(Node root, int k)
        {
            while(root != null)
            {
                if(k > root.value)
                {
                    root = root.right;
                }

                else if(k < root.value)
                {
                    root = root.left;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }

}

//Breadth first search(bfs): BFS is a traversing algorithm where you should start traversing from a selected node (source or starting node) and traverse the graph layerwise 
//thus exploring the neighbour nodes (nodes which are directly connected to source node). You must then move towards the next-level neighbour nodes.


