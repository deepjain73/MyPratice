using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class CountTriplets
    {
        public void countTriplets(int[] n)
        {
            if (n == null || n.Length <= 1)
            {
                return;
            }

            //Sorting

            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] > n[j])
                    {
                        int temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                    }
                }
            }

            int start = 0, end = n.Length - 2, count = 0, l = n.Length; Boolean b = false;

            for(int i = start;i<l-1; i++)
            {
                int sum = n[start] + n[end];

                if (sum < n[l-i-1] )
                {
                    start++;
                }
                else if(sum == n[l-i-1])
                {
                    start++;
                    end--;
                    count++;
                    b = true;
                }
                else if(sum > n[l-i-1])
                {
                    end--;
                }
            }

            if (b == true)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("-1");
            }

           
            
               
           

            
        }
    }
}
