using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class DoublyLinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node prev;
            public Node next;

            public Node(int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }

        public void addnode(Node n, int d)
        {
          
        }

        public void printlist(Node n)
        {

        }

    }
}
