using System;
using System.Collections.Generic;
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
           if(head == null || head.next == null)
            {
                return head;
            }

            int count = 0;
            Node previous=null;
            Node next = null;
            Node current = head;

            while (count < k && n != null)
                {
                    next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                    count++;
                }

           
                head = previous;
            return previous;
         }

                
            
        public void printlist(Node n)
        {
            if(head == null || head.next == null)
            {
                Console.WriteLine("list is empty");
            }

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