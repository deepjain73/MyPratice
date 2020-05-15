using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ContinousSubarray
    {
        int[] c = new int[] { 1,4,20,3,10,5 };
        int sum = 33;
        int result;
        Boolean b = false;

        public void continoussubarray()
        {
            for (int i = 0; i < c.Length; i++)
            {
                    result = 0;
                
                    for (int j = i; j < c.Length; j++)
                    {
                        result = result + c[j];

                        if (result == sum)
                        {
                            b = true;
                            Console.WriteLine("Sum found between indexes " + i + " - " + j);
                            break;
                        }
                    }
                }
                 if(b == false)
                Console.WriteLine("No range found");
            }
        }
}

