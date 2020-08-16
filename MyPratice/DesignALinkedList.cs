using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class DesignALinkedList
    {
        public Node head;

        public class Node
        {
            public int value;
            public Node next;

            public Node(int val)
            {
                this.value = val;
                this.next = null;
            }
        }

        /** Initialize your data structure here. */
        public DesignALinkedList()
        {
            this.head = null;

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {

            if (head == null)
            {
                return -1;
            }

            Node current = head;



            int i = 0;

            while (current != null)
            {
                if (i == index)
                {
                    return current.value;
                }
                current = current.next;
                i++;
            }

            return -1;

        }



        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {

            Node n = new Node(val);

            if (head == null)
            {
                head = n;
            }
            else
            {
                n.next = head;
                head = n;
            }

        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {

            Node n = new Node(val);

            if (head == null)
            {
                head = n;
            }

            Node current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = n;

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {

            if (index < 0)
                return;


            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            Node n = new Node(val);
            Node current = head;
            int i = 0;

            while (current != null && i != index - 1)
            {
                current = current.next;
                i++;
            }

            if (current != null)
            {
                n.next = current.next;
                current.next = n;
            }



        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {

            if (index < 0)
                return;

            if (index == 0)
            {
                head = head.next;
                return;
            }

            Node current = head;
            int i = 0;

            while (current != null && i != index - 1)
            {
                current = current.next;
                i++;
            }

            if (current != null && current.next != null)
            {
                current.next = current.next.next;
            }

        }

        public void printlist()
        {
            Node n = head;
            Console.WriteLine(n.value);
            n = n.next;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */