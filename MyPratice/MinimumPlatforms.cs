using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class MinimumPlatforms
    {
        public void findminplat(int[] arr, int[] dep)
        {
            int count = 1, result = 1;
            int i = 1, j = 0;

            while(i < arr.Length && j < dep.Length)
            {
                if(arr[i] < dep[j])
                {
                    count++;
                    i++;

                    if(count > result)
                    {
                        result = count;
                    }
                }

                else
                {
                    count--;
                    j++;
                }
            }

            Console.WriteLine(result);
           
            
        }

    }
}
