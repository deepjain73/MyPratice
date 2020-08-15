using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyPratice
{
    class ReverseLinkedList
    {

        public Node head;

        public class Node
        {
            public int value;
            public Node next;
          

            public Node(int v)
            {
                value = v;
                next = null;
            }
        }



        public Node reverselist(Node n,int k)
        {
           //if(head == null || head.next == null)
           // {
           //     return head;
           // }

            int count = 0;
            Node previous = null;
            Node next = null;
            Node current = n;
           // int i = 0;
            //Node last = null;

            while (count < k && current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                count++;
            }

            if (next != null)
            {
                n.next = reverselist(next, k);
            }

            return previous;

            //    if (count == 0)
            //    {
            //        last = current;
            //    }
            //    if (count == k)
            //    {
            //        if (i == 0)
            //        {
            //            head = previous;
            //            last = current;

            //        }
            //        i++;
            //        count = 0;
            //    }
            //}
        }

        public Node reversealist(Node n)
        {
            

            Node prev = null;
            Node next = null;
            Node current = n;

            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }


            return prev;
        }







        public void printlist(Node n)
        {
            //if(head == null || head.next == null)
            //{
            //    Console.WriteLine("list is empty");
            //}

            while(n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }
        }

    }
}


// Time: O(n)
// space O(n)