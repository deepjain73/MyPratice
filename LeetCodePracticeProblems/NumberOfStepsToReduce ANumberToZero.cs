using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class NumberOfStepsToReduce_ANumberToZero
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;

            while(num > 0)
            {
                count++;

                if(num % 2 == 0)
                {
                    num = num / 2;
                }

                else
                {
                    num = num - 1;
                }
            }

            return count;
        }
    }
}
