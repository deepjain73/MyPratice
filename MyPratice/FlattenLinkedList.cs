using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MyPratice
{
    class FlattenLinkedList
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

     
       public void printlist(Node c)
        {
            while(c != null)
            {
                printlistnew(c);
                c = c.bottom;
            }
        }

        public void printlistnew(Node c)
        {
            while( c != null)
            {
                Console.WriteLine(c.data);
                c = c.next;
            }
        }


        public Node mergelist(Node a, Node b)
        {
            if (a == null)            
                return b;
            
            if (b == null)            
                return a;
                    
            if(a.data < b.data)
            {
                a.next = mergelist(a.next, b);
                return a;
            }
            else
            {
                b.next = mergelist(a, b.next);
                return b;
            }

        }

      


        public void flattenlist(Node n)
        {
            while (n.bottom != null)
            {
                var tmp = n.bottom;
                n = mergelist(n, n.bottom);
                n.bottom = tmp.bottom;               
            }

            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
            
        }
}
