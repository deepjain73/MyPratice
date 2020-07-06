using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MyPratice
{
    class findlength
    {
        public Node head;

        public class Node
        {
            public Node next;
            public int data;


            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        //public int findarraylength()
        //{
        //    int[] s = new int[] { 1, 2, 3, 4, 5, 6 };
        //    var p = 0;

        //    for (; s[p] != '\n';)
        //    {
        //        p = p + 1;
        //    }

        //    return p;
        //}

        public int findlinkedlistlength(Node n)
        {
           var l = 1;
           
           while(n != null)
            {
                n = n.next;
                l++;
            }

            return l;
        }
    }
}
