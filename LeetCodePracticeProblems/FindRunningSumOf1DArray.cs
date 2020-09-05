using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCodePracticeProblems
{
    class FindRunningSumOf1DArray
    {
        public void runningsum(int[] s)
        {
            int result = 0;
            int[] n = new int[s.Length];

            if (s == null || s.Length <= 1)
            {
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                result = result + s[i];
                //Console.WriteLine(result);
                n[i] = result;
                Console.WriteLine(n[i]);
            }

            
        }

        public int[] RunningSum(int[] nums)
        {

            int result = 0;
            int[] n = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
                result = result + nums[i];
                n[i] = result;

            }

            return n;
        }
    }
}
