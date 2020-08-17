using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class IntersectingLinkedList
    {
        public Node headA;
        public Node headB;
        public class Node
        {
            public Node next;
            public int data;

            public Node(int d)
            {
                this.next = null;
                this.data = d;
            }
        }

        public Node intersect(Node headA, Node headB)
        {
            if (headA == null || headB == null)
                return null;

            Node A = headA;
            Node B = headB;

            int bNullCount = 0;
            while (true)
            {
                if (A == B)
                    return A;

                if (A.next == null)
                {
                    A = headB;
                    bNullCount++;
                }
                if (B.next == null)
                {
                    B = headA;
                    bNullCount++;
                }
                if (bNullCount == 3)
                {
                    break;
                }

                A = A.next;
                B = B.next;

            }
            return null;


        }

        public Node inttersecting(Node a,Node b)
        {
            if (a == null || b == null)
                return null;

            Dictionary<Node, int> d = new Dictionary<Node,int>();
            while(a != null)
            {
                d.Add(a,1);
                a = a.next;
            }
           while (b != null)
            {
                if(d.ContainsKey(b))
                {
                    return b;
                }
                b = b.next;
            }
            return null;


        }
        public void print(Node n)
        {
            while(n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
