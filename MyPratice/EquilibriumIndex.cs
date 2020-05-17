using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class EquilibriumIndex
    {
        public int equilibriumIndex(int [] Array,int n)
        {
            
            int leftsum; int rightsum;
            
            for(int i = 1; i<n; i++)
            {
                leftsum = 0;
                rightsum = 0;

                for(int j = 0; j<i; j++)
                {
                    leftsum = leftsum + Array[j];
                }

                for (int j = i+1; j < n; j++)
                {
                    rightsum = rightsum + Array[j];
                }

                if(leftsum == rightsum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
// complexity n*n 