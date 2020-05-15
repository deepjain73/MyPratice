using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SortAnArray
    {
        int a0;
        int b1;
        int c2;
        

        public void sortanarray(int[] san)
        {
            for(int i =0; i<san.Length; i++)
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

            while(a0>0)
            {
                a0--;
                Console.Write("0");
            }
            while (b1 > 0)
            {
                b1--;
                Console.Write("1");
            }
            while (c2 > 0)
            {
                c2--;
                Console.Write("2");
            }
        }
    }
}
