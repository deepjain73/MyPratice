using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Findtheduplicate
    {
        public int findduplicate(int[] d)
        {
            //int n = d.Length, currsum = 0, expsum = n * (n - 1) / 2;

            //for (int i = 0; i < n; i++)
            //{
            //    currsum = currsum + d[i];
            //}
            //return currsum - expsum;

            int actualresult = 0, n = d.Length;

            if (n == 0 || n <= 1)
                return -1; //array is empty

            for(int i =0;i<n;i++)
            {
                actualresult += d[i] - (i + 1);
            }
            return actualresult;
        }

    }
    
}

// complexity is O(n)