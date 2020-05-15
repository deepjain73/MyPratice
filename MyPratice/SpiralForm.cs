using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class SpiralForm
    {
        public void printinSpiralForm()
        {
            int[,] Array2d = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int r = 4, c = 4, k = 0, l = 0;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(Array2d[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            while (k < r && l < c)
            {
                // Print the first row  
                // from the remaining rows 
                for (int i = l; i < r; ++i)
                {
                    Console.Write(Array2d[k, i] + " ");
                }
                k++;

                // Print the last column from the 
                // remaining columns 
                for (int i = k; i < r; ++i)
                {
                    Console.Write(Array2d[i, c - 1] + " ");
                }
                c--;

                // Print the last row from  
                // the remaining rows  
                if (k < r)
                {
                    for (int i = c - 1; i >= l; --i)
                    {
                        Console.Write(Array2d[r - 1, i] + " ");
                    }
                    r--;
                }

                // Print the first column from  
                // the remaining columns 
                if (l < c)
                {
                    for (int i = r - 1; i >= k; --i)
                    {
                        Console.Write(Array2d[i, l] + " ");
                    }
                    l++;
                }
            }
        }
    }
}

 


    
// no extra space
// o(r*c)