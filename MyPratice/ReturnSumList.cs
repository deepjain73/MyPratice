using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MyPratice
{
    class ReturnSumList
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

        public void sumoflist(Node n1, Node n2)
        {
            int carry = 0;
            int sum = 0;

            while (n1 != null || n2 != null)
            {
                if (n1 == null)
                {
                    sum = carry + n2.data;
                    carry = sum / 10;
                    sum = sum % 10;
                }

                else if (n2 == null)
                {
                    sum = carry + n1.data;
                    carry = sum / 10;
                    sum = sum % 10;
                }

                else
                {
                    sum = carry + n1.data + n2.data;
                    carry = sum / 10;
                    sum = sum % 10;
                }

                Console.WriteLine(sum);

                if (n1 != null)
                {
                    n1 = n1.next;
                }

                if (n2 != null)
                {
                    n2 = n2.next;
                }
            }
        }

        //public void printlist(Node n)
        //{
        //    while (n != null)
        //    {
        //        Console.WriteLine(n.data);
        //        n = n.next;
        //    }
        //}
    }
}
