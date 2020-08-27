using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class InversionOfArray
    {
        public void inversion(int[] n)
        {
            int count = 0;

            for(int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] > n[j])
                    {
                        int temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                        count++;
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
