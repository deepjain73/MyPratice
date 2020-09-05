
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class GoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                for(int j = i+1; j<nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        count++;
                        Console.WriteLine("({0} , {1})",i,j);
                    }
                }
            }

            if(count>0)
            {
                return count;
            }
            return 0;

        }
    }
}
