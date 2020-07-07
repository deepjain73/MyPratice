using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SwapPairwise
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

        public void swappairwise(Node n)
        {
            if(head == null || head.next == null)
            {
                Console.WriteLine(head);
            }

            while ( n != null && n.next != null)
            {
                int k = n.data;
                n.data = n.next.data;
                n.next.data = k;
                n = n.next.next;
            }
        }

        public void printlist(Node n)
        {
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
