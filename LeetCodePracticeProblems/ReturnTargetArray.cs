using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodePracticeProblems
{
    class ReturnTargetArray
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            //int[] target = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (index[i] < i)
                {

                    int temp = nums[index[i]];
                    nums[index[i]] = nums[i];

                    for (int j = index[i] + 1; j <= i; j++)
                    {
                        int x = nums[j];
                        nums[j] = temp;
                        temp = x;
                    }
                }
            }

            return nums;
        }
    }
}

       
        

    
