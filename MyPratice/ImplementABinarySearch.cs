using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ImplementABinarySearch
    {
        public int searchandsort(int[] s , int k)
        {
            for(int i = 0;i<s.Length;i++)
            {
                for(int j = i+1; j<s.Length;j++)
                {
                    if(s[j]<s[i])
                    {
                        int temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }// bubble sort
                }
            }

            int high = s.Length - 1, low = 0, mid = 0;

            while(low<=high)
            {
                mid = (low + high) / 2;

                if (s[mid] == k)
                    return mid;

                if(k > s[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
