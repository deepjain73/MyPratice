using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            int length = 0, k = 0;

            for (int i = 0; i < nums.Length; i = i + 2)
            {
                length = length + nums[i];
            }
            var n = new int[length];

            for (int i = 0; i < nums.Length; i = i + 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    n[k] = nums[i + 1];
                    k++;
                }
            }

            return n;
        }
    }
}
