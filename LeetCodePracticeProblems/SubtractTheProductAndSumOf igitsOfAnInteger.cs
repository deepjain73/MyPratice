using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class SubtractTheProductAndSumOf_igitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            if (n < 10)
            {
                return -1;
            }

            int sum = 0, product = 1, result = 0, carry = 0;
            {
                while(n != 0)
                {
                    carry = n % 10;
                    n = n / 10;
                    sum = sum + carry;
                    product = product * carry;
                }
            }

            result = product - sum;
            return result;
        }
    }
}
