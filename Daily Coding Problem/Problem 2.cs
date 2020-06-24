using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daily_Coding_Problem
{
    class Problem_2
    {
        int[] s = new int[] { 1, 2, 3, 4, 5 };

        public void productofarray()
        {
            var v = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                var product = 1;

                for (int j = 0; j < s.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    product = product * s[j];
                }

                v[i] = product;
                Console.WriteLine(v[i]);
            }
        }
    }
}










//This problem was asked by Uber.
//Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
//For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
//Follow-up: what if you can't use division?

