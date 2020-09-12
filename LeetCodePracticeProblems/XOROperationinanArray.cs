using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class XOROperationinanArray
    {
        public int XorOperation(int n, int start)
        {
            int[] nums = new int[n];
            int xor = 0;

            for(int i = 0; i<n; i++)
            {
                nums[i] = start + 2 * i;
                xor = xor ^ nums[i];
            }

            return xor;

        }
    }
}
