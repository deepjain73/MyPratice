using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class NextGreaterElement
    {
        int[] arr = new int[] { 13, 7, 6, 1 };

        public void printnextelement()
        {
            int n = arr.Length;

            if(n == 0 || n <= 1)  // checking if array is empty or not
            {
                Console.WriteLine("Array is empty");
            }

            for(int i = 0; i < n; i++)
            {
                int next = -1;  // resetting next value to -1

                for(int j = i+1; j < n; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        next = arr[j];  // assigning arr[j] into next
                        break;
                    }
                }
                Console.WriteLine(arr[i] + " "  + "-->" + " " + next);
            }
        }



    }
}
