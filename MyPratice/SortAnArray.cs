using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SortAnArray
    {
        
        

        public void sortanarray(int[] san)
        {
            int n = san.Length; int a0=0,
             b1=0, c2=0;

            if (n == 0 || n <= 1)
                Console.WriteLine("Array is empty");

            for(int i =0; i<n; i++)
            {
                if(san[i]==0)
                {
                    a0++;
                }
                else if(san[i]==1)
                {
                    b1++;
                }
                else if(san[i]==2)
                {
                    c2++;
                }
            }

            while(a0 > 0)
            {
                a0--;
                Console.Write("0" + " ");
            }
            while (b1 > 0)
            {
                b1--;
                Console.Write("1" + " ");
            }
            while (c2 > 0)
            {
                c2--;
                Console.Write("2" + " ");
            }

            Console.WriteLine(" ");
        }
    }
}
