using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MyPratice
{
    class FindDupLinkedList
    {
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

        public Node distinctLinkedList(Node input)
        {


            Dictionary<Node, int> d = new Dictionary<Node, int>();
            if (input == null)
                return null;

            Node pre = null;

            while (input != null)
            {
                if (d.ContainsKey(input))
                {

                    pre.next = input.next;
                }

                else
                {
                    d.Add(input, 1);
                    pre = input;
                }
                input = input.next;
            }
            return pre;

        }
    }
}

