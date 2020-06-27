using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    public class FindMiddelOfTheLinkedlist
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                this.data = d;
                this.next = null;
            }
        }

        public int findmiddle(Node n)
        {
            if (head == null || head.next == null)
                Console.WriteLine("List is empty");

            var slowpointer = head;
            var fastpointer = head;

            if (head != null)
            {
                while (fastpointer != null && fastpointer.next != null)
                {
                    fastpointer = fastpointer.next.next;
                    slowpointer = slowpointer.next;
                }

            }

            return slowpointer.data;
        }

        //public void addnode(Node n, int data)
        //{
        //    while (n != null)
        //    {
        //        Console.WriteLine(n.data);
        //        n = n.next;
        //        if (n != null)
        //            n = n.next;
        //    }
        //}


    public void printList(Node n)
        {
            if (head == null || head.next == null)
                Console.WriteLine("head is null");

            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
