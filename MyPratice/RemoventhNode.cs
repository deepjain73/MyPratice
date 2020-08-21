using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class RemoventhNode
    {
        public Node head;


        public class Node
        {
            public int data;
            public Node next;
            public Node bottom;


            public Node(int d)
            {
                data = d;
                next = null;
                bottom = null;
            }
        }
        public Node RemoveNthFromEnd(Node head, int n)
        {

            if (head == null || head.next == null)
            {
                return null;
            }

            if(n < 1)
            {
                return head;
            }

            int i = 0;
            Node f = head;
            Node s = head;

            while (f != null && i < n)
            {
                f = f.next;
                i++;
            }

            if (i != n)
            {
                return null;
            }


            while (f.next != null)
            {
                f = f.next;
                s = s.next;
            }

            s.next = s.next.next;

            return head;
        }

        public void print(Node n)
        {
            while(n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
