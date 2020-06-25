using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    public class FindMiddelOfTheLinkedlist
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

        public void findmiddle(Node n)
        {
            if (head == null || head.next == null)
                Console.WriteLine("head is null");
            
            
            
            //why head is assigned to local variable, isn't it Node n?????--Kapil

            var slow = head;
            var fast = head;

            
        }
    }
}
