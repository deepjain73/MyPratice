using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class FindASubarray
    {
        int[] s = new int[] { 10, 2, -2, -20, 10 };
        int sum = -10;
        int result;
        Boolean b = false;

        public void findAsubarray()
        {
            for (int i = 0; i < s.Length; i++)
            {
                result = 0;

                for (int j = i; j < s.Length; j++)
                {
                    result = result + s[j];

                    if (result == sum)
                    {
                        b = true;
                        Console.WriteLine("sum found between indexes " + i + " - " + j);
                    }
                }
            }
            if (b == false)
                Console.WriteLine("No subarray with given sum exists");
        }
    }
}
