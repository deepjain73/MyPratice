using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class CountGoodTriplets
    {
        public int countGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;

            for(int i = 0; i<arr.Length-2; i++)
            {
                for(int j = i+1; j<arr.Length-1; j++)
                {
                    for(int k = j+1; k<arr.Length; k++)
                    {
                        if(Math.Abs(arr[i]-arr[j]) <= a && Math.Abs(arr[j]-arr[k]) <= b && Math.Abs(arr[i]-arr[k]) <= c)
                        {
                            Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k]);
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
