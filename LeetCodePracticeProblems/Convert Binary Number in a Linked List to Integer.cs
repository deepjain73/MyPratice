using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LeetCodePracticeProblems
{
    class Convert_Binary_Number_in_a_Linked_List_to_Integer
    {

        public class Node
        {
            public int value;
            public Node next;

            public Node(int v)
            {
                this.value = v;
                this.next = null;
            }
        }
        public int GetDecimalValue(Node head)
        {
            int length = 0;
            Node n = head;
            while(n != null)
            {
                n = n.next;
                length++;
            }

            int[] arr = new int[length];
            Node c = head;
            int i=0;

            while(c != null)
            {
                arr[i] = c.value;
                c = c.next;
                i++;
            }

            double sum = 0, power = 0;

            for(int j=arr.Length-1; j >= 0; j--)
            {
                sum = sum + (Math.Pow(2.0, power)*arr[j]);
                power++;
            }

            return (int)sum;
            
        }

        public int GetDecimalValue1(Node head)
        {
            int num = 0;
            while (head != null)
            {
                num *= 2;
                num += head.value;
                head = head.next;
            }
            return num;
        }
    }
}
