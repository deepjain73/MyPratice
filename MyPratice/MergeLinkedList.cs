using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class MergeLinkedList
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

        public void mergedlinkedlist(Node n,Node tmp)
        {
            //if (head == null || head.next == null)
            //{
            //    return;
            //}
            var head = n;

            if (n == null)
            {
                Console.WriteLine (tmp);
            }
                
            if(tmp == null)
            {
                Console.WriteLine( n);
            }



       
            while (n != null || tmp != null)
            {
                if(n == null)
                {
                   
                    break;
                }
                if(tmp.next == null)
                {
                    tmp.next = n.next;
                    break;
                }
                if (n.next.data > tmp.data)
                {
                    Node newtmp = n.next;
                    n.next = tmp;
                    tmp = newtmp;
                    
                }
                else                    
                    tmp = tmp.next;

            }

            

            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }


        }

        //public void printlist(Node n)
        //{
        //    while(n != null)
        //    {
        //        Console.WriteLine(n.data);
        //        n = n.next;
        //    }
        //}
    }
}
