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
            public Node bottom;


            public Node(int d)
            {
                data = d;
                next = null;
                bottom = null;
            }
        }

        public void mergedlinkedlist(Node l1,Node l2)
        {
            //if (head == null || head.next == null)
            //{
            //    return;
            //}
            //var head = n;

            if (l1 == null)
            {
                Console.WriteLine (l2);
            }
                
            if(l2 == null)
            {
                Console.WriteLine(l1);
            }

            
            if(l1.data < l2.data)
            {
                head = l1;
            }
            else
            {
                head = l2;
                l2 = l1;
                l1 = head;
            }
       
            while (l1 != null && l2 != null)
            {
                //if(n == null)
                //{
                   
                //    break;
                //}
                //if(tmp.next == null)
                //{
                //    tmp.next = n.next;
                //    break;
                //}

                if (l1.next.data > l2.data)
                {
                    Node tmp = l2.next;
                    Node newtmp = l1.next;
                    l1.next = l2;
                    l2.next = newtmp;

                    if(l2.next != null)
                    {
                        l2 = tmp;
                    }

                }
                else
                {
                    l1 = l1.next;
                }

            }

      
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

            //if (a.data < b.data)
            //{
            //    a.next = mergelist(a.next, b);
            //    return a;
            //}

            //else
            //{
            //    b.next = mergelist(a, b.next);
            //    return b;
            //}
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
