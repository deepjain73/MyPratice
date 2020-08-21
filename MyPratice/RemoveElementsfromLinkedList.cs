using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class RemoveElementsfromLinkedList
    {
        public Node head;

        public class Node
        {
            public int v;
            public Node next;

            public Node(int val)
            {
                v = val;
                next = null;
            }
        }
        public Node RemoveElements(Node head, int val)
        {
            if (head == null)
            {
                return null;
            }

            Node dummy = new Node(0);
            dummy.next = head;
            Node c = head;
            Node pre = dummy;

            while (c != null)
            {
                if (c.v == val)
                {
                    pre.next = c.next;
                }
                else
                {
                    pre = c;
                }
                c = c.next;

            }

            return dummy.next;

        }
    }
}
