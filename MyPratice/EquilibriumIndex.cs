using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class EquilibriumIndex
    {
        public int equilibriumIndex()
        {
            int[] Array = new int[] { -7, 1, 5, 2, -4, 3, 0 };
            int leftsum; int rightsum;

            for(int i = 1; i<Array.Length-1; i++)
            {
                leftsum = 0;
                rightsum = 0;

                for(int j = 0; j<i; j++)
                {
                    leftsum += Array[j];
                }

                for (int j = i+1; j < Array.Length; j++)
                {
                    rightsum += Array[j];
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
