using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SmallestElement
    {
        
        public int smallestElement(int[] smallarray,int k)
        {
            int j; int min; int temp; int n = smallarray.Length;
            for (int i = 0; i < n-1; i++)
            {
                min = i;
                for (j = i+1; j<n; j++)
                    {
                        if(smallarray[j]<smallarray[min])
                        {
                            min = j;
                        }
                    }

                    temp = smallarray[min];
                    smallarray[min] = smallarray[i];
                    smallarray[i] = temp;
               }
            Console.WriteLine("Array in Sorted Form: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(smallarray[i] + " ");
            }

            Console.WriteLine();

            return smallarray[k];



        }
    }
}

