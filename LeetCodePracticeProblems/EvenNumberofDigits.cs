using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class EvenNumberofDigits
    {
        public int FindNumbers(int[] nums)
        {
            if(nums == null)
            {
                return 0;
            }

            int counter = 0;
            for(int i = 0; i< nums.Length; i++)
            {
                if(getdigits(nums[i])%2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public int getdigits(int n)
        {
            int count = 0;

            while(n > 0)
            {
                n = n / 10;
                count++;
            }

            return count;
        }
    }
}
