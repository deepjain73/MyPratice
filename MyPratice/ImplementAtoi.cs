using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ImplementAtoi
    {
        string a = "a4367";

        public void atoi()
        {
            int output = 0;
            for(int i =0; i<a.Length; i++)
            {
                if(a[i] <48 || a[i]>59)
                {
                    Console.WriteLine("Not valid integer");
                    break;
                }
                output = output * 10 + a[i] - '0';
            }

            Console.WriteLine(output);
        }
    }
}
