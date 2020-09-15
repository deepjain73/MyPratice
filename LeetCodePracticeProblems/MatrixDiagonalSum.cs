
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class MatrixDiagonalSum
    {
        public int DiagonalSum(int[,] mat, int t)
        {
            int sum = 0;

            for(int i = 0; i<t; i++)
            {
                sum = sum + mat[i, i];

                if(t-i-1 == i)
                {
                    continue;
                }

                else
                {
                    sum = sum + mat[i,t-i-1];
                }
            }
            return sum;
        }
    }
}
