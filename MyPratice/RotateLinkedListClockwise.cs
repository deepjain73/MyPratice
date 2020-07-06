using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace MyPratice
{
    class RotateLinkedListClockwise
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

        public void printList(Node n)
        {
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }

        public void rotateclockwise(Node n,int k)
        {
            if(k == 0)
            {
                return;
            }

            int count = 1;

            while( count < k && n != null)
            {
                n = n.next;
                count++;
            }

            if( n == null)
            {
                Console.WriteLine("Head is null");
            }

            Node kthNode = n;

            while(n.next != null)
            {
                n = n.next;
            }

            n.next = head; ;
            head = kthNode.next;
            kthNode.next = null;
        }
    }
}



// complexity O(n);