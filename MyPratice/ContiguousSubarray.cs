using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ContiguousSubarray
    {
        public void SumOfContiguousSubarray(int[] b)
        {
            int sum = 0;
            int maxsumuptonow = 0;

            for (int i = 0; i < b.Length; i++)
            {
                if(b[i] > 0 && sum < 0)
                {
                    sum = 0;
                }

                sum = sum + b[i];

                if(sum > maxsumuptonow)
                {
                    maxsumuptonow = sum;
                }
            }

            Console.WriteLine("The largest sum of contiguous subarray is" + " " + maxsumuptonow);
       }

        public void contiguous(int[] n)
        {
            int sum = 0, maxsum = int.MinValue;
            for (int i = 0; i < n.Length; i++)
            {
                if(n[i] > 0 && sum < 0)
                {
                    sum = 0;
                }
                sum = sum + n[i];

                if (sum > maxsum)
                    maxsum = sum;
            }
            Console.WriteLine(maxsum);
        }
    }
}
