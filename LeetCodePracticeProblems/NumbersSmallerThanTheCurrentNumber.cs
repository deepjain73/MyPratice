using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCodePracticeProblems
{
    class NumbersSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return nums;
            }

            int count = 0;
            int[] n = new int[nums.Length];

            for(int i = 0; i<nums.Length; i++)
            {
                count = 0;
                for(int j = 0; j<nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        count++;
                    }
                    
                }
                n[i] = count;
            }


            
            return n;
        }
    }
}


