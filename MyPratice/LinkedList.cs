using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MyPratice
{
    class LinkedList
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

        public void printList(Node n)
        {
            if (head == null || head.next == null)
                Console.WriteLine("head is null");

            while(n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }

        public void printAlternateItemInList(Node n)
        {
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
                if (n !=null)
                    n = n.next;
            }
        }

        public void printNthNodeValue(Node n, int nth)
        {
            int i = 1;

            while (n != null)
            {
                if(i == nth)
                Console.WriteLine(n.data);
                n = n.next;
                i++;
            }

            
        }
    }
}
