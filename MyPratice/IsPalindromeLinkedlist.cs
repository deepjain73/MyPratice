using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class IsPalindromeLinkedlist
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

        public bool isPalindrome(Node n)
        {
            //int length = 0;

            //while(n != null)
            //{
            //    n = n.next;
            //    length++;
            //}

            //Console.WriteLine(length);

            //int i = 0;
            //int[] myarray = new int[length];
            //Node c = head;
            //int a = myarray.Length;

            //while (c != null)
            //{
            //    myarray[i] = c.data;
            //    c = c.next;
            //    Console.WriteLine(myarray[i]);
            //    i++;
            //}

            //for(int j = 0, k = a-1; j < a/2; j++, k--)
            //{
            //    if(myarray[j] != myarray[k])
            //    {
            //        return false;
            //    }
            //}

            //return true;


            int length = 0;

            while (n != null)
            {
                n =n.next;
                length++;
            }

            Node current = head;
            int[] arr = new int[length];
            int i = 0;

            while (current != null)
            {
                arr[i] = current.data;
                current = current.next;
                i++;

            }



            for (int j = 0; j < arr.Length / 2; j++)
            {
                if (arr[j] != arr[arr.Length - j - 1])
                {
                    return false;
                }
            }
            return true;

        }


    }
}
