using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Findnthnode
    {
        public Node head;

        public class Node
        {
            public Node next;
            public int data;


            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

       public int findnthNode(Node n, int k)
        {
            if (head == null || k < 1)
                return -1;

            int i = 0;
            Node c = head;
            Node v = head;

            while(n.next != null && i < k)
            {
                v = v.next;
                i++;
            }

            if (i != k)
                return -1;

        while(v != null)
            {
                c = c.next;
                v = v.next;
            }

            return c.data;
        }
    }
}
