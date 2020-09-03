using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyPratice
{
    class LeadersArray
    {
        public void leaderArray()
        {
            int[] array = new int[] { 7,4,5,7,3 };
            int j;
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                for( j = i+1; j < n; j++)
                {
                    if (array[j] > array[i])
                        break;
                }
                if (j == n)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
        }
    }
}

// last element will always be leader
//time corplexity n*n