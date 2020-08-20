using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Circularlinkedlist
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

        public bool IsCircular(Node n)
        {
            if (head == null || head.next == null)
                Console.WriteLine("List is empty");

            var slowpointer = head;
            var fastpointer = head;


            while (fastpointer != null && slowpointer != null && fastpointer.next != null && slowpointer.next != null)
            {
                fastpointer = fastpointer.next.next;
                slowpointer = slowpointer.next;

                if (slowpointer == fastpointer)
                {
                    //slowpointer = head;

                    //while (slowpointer != fastpointer)
                    //{
                    //    slowpointer = slowpointer.next;
                    //    fastpointer = fastpointer.next;
                    //}
                    //return true; 

                    // return slowpointer.data;
                    return true;
                }
            }

            // return -1;
            return false;
        }

        public Node DetectCycle(Node head)
        {

            if (head == null || head.next == null)
            {
                return null;
            }

            Node s = head;
            Node f = head;

            while (f != null && f.next != null)
            {
                s = s.next;
                f = f.next.next;

                if (s == f)
                {
                    s = head;
                    while (s != f)
                    {
                        s = s.next;
                        f = f.next;
                    }
                    return s;
                }
            }

            return null;
        }
    }
}


// time complexity O(n)
// space O(n)