using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class RearrangeArrayAlternately
    {
        public void rearrange(int[] arr)
        {
            int temp;

            for(int i = 0; i<arr.Length;i++)
            {
                if(i % 2 == 0)
                {
                    temp = arr[arr.Length - 1];

                    for(int j = arr.Length-2; j >= i; j--)
                    {
                        arr[j + 1] = arr[j];
                    }

                    arr[i] = temp;
                }
            }

            for(int i = 0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
            
    }
}
