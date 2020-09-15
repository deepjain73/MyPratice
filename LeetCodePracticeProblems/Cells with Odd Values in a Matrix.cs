using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class Cells_with_Odd_Values_in_a_Matrix
    {
        public int OddCells(int n, int m, int[,] indices,int x)
        {

            int[,] s = new int[n, m];

            for(int i = 0; i<n;i++)
            {
                for(int j = 0; j<m;j++)
                {
                    s[i, j] = 0;
                }
            }

            for(int i = 0; i<x; i++)
            {
                int r = indices[i,0];
                int c = indices[i,1];

                for(int j = 0; j<m; j++)
                {
                    s[r, j] = s[r, j] + 1;
                }

                for (int j = 0; j < n; j++)
                {
                    s[j,c] = s[j,c] + 1;
                }
            }

            int count = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(s[i,j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
