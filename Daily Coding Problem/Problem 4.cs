using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Problem
{
    class Problem_4
    {
       

        public int[] selectionsort(int[] s)
        {
            if(s == null || s.Length == 0)
            {
                Console.WriteLine("Array is empty");
            }

            int temp, j, min;

            for (int i = 0; i < s.Length; i++)
            {
                min = i;

                for (j = i + 1; j < s.Length; j++)
                {
                    if (s[j] < s[min])
                    {
                        min = j;
                    }
                }

                temp = s[min];
                s[min] = s[i];
                s[i] = temp;

                
            }

            return s;
        }

        public void findpositiveint()
        {
            //for (int k = 0; k < s.Length; k++)
            //{
            //    if (s[k] != k + 1)
            //    {

            //        Console.WriteLine(k + 1);
            //    }
            //}

            //Console.WriteLine(s.Length + 1);
            int[] s = new int[] { 3, 4, -1,1 };
            selectionsort(s);

            Boolean bfound = false;
            int Exceptedsum; int l = s[0];

            for (int k = 0; k < s.Length; k++)
            {
                Exceptedsum = l + k;
                if (Exceptedsum != s[k])
                {
                    bfound = true;
                    Console.WriteLine($"Missing positive Number is  { Exceptedsum}");
                    break;
                }
            }
            if (bfound == false)
                Console.WriteLine("No missing positive number");
        }
    }
}




//This problem was asked by Stripe.
//Given an array of integers, find the first missing positive integer in linear time and constant space.In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
//For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
//You can modify the input array in-place

