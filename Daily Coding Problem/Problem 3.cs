using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Problem
{
    class Problem_3
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int v)
            {
                value = v;
                left = null;
                right = null;
            }
        }

        public void serialize(Node root)
        {
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
            }


        }

        public void deserialize()
        {
           


        }
    }
}





//This problem was asked by Google.
//Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.
//For example, given the following Node class
//class Node :
//    def __init__(self, val, left=None, right=None):
//        self.val = val
//        self.left = left
//        self.right = right
//The following test should pass:
//node = Node('root', Node('left', Node('left.left')), Node('right'))
//assert deserialize(serialize(node)).left.left.val == 'left.left'



// Serialization is to store tree in a file so that it can be later restored. The structure of tree must be maintained. Deserialization is reading tree back from file.
// Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
