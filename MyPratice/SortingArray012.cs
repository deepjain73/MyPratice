using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SortingArray012
    {
        public void sortingarray(int[] n)
        {
            int low = 0, high = n.Length - 1, mid = 0, temp = 0;

            while(mid <= high)
            {
                if(n[mid] == 0)
                {
                    temp = n[low];
                    n[low] = n[mid];
                    n[mid] = temp;
                    mid++;
                    low++;
                    
                }

                else if(n[mid] == 1)
                {
                    mid++;
                }

                else if(n[mid] == 2)
                {
                    temp = n[mid];
                    n[mid] = n[high];
                    n[high] = temp;
                    high--;
                    
                }
            }

            for(int i = 0; i<n.Length;i++)
            {
                Console.WriteLine(n[i]);
            }
        }

        public void sort(int[] n)
        {
            int acount = 0, bcount = 0, ccount = 0;
            for(int i = 0;i<n.Length;i++)
            {
                if (n[i] == 0)
                { 
                    acount++; 
                }
                    

                else if(n[i] == 1)
                {
                    bcount++;
                }

                else if(n[i] == 2)
                {
                    ccount++;
                }
            }

             int j = 0;
            while(acount > 0)
            {
                n[j++] = 0;
                acount--;
            }
            while (bcount > 0)
            {
                n[j++] = 1;
                bcount--;
            }
            while (ccount > 0)
            {
                n[j++] = 2;
                ccount--;
            }

            for(int i = 0;i<n.Length;i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}


//Time complexity = O(n);
//Space complexity = O(1) constant;
