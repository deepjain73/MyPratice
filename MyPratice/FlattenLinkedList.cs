using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class FlattenLinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

        }
    }
}
