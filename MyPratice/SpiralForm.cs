using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SpiralForm
    {
        public void printinSpiralForm()
        {
            //int[,] array2d = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //int m = 4, n = 4, k = 0, l = 0;

            //int[,] array2d = new int[3, 3] { { 1, 2, 3}, { 5, 6, 7 }, { 9, 10, 11 }};
            //int m = 3, n = 3, k = 0, l = 0;


            int[,] array2d = new int[3, 6] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 } };
            int m = 3, n = 6, k = 0, l = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array2d[i, j] + " ");
                }
                Console.WriteLine();
            }

            while (k<m && l<n)
            {
                for(int i = l; i<n;i++)
                {
                    Console.Write(array2d[k,i]+ " ");
                }
                k++;

                for(int i = k; i<m; i++)
                {
                    Console.Write(array2d[i, n-1] + " ");
                }
                n--;
                if (k < m)
                {
                    for (int i = n - 1; i >= l; i--)
                    {
                        Console.Write(array2d[m - 1, i] + " ");
                    }
                    m--;
                }
                if (l < n)
                {
                    for (int i = m - 1; i >= k; i--)
                    {
                        Console.Write(array2d[i, l] + " ");
                    }
                    l++;
                }
            }
        }
    }
}

 


    
// no extra space
// o(r*c)