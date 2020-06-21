using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ImplementAtoi
    {
        string a = "1234";

        public int atoi()
        {
            int output = 0;

            if(a.Length == 0 || a.Length <= 1)
            {
                return -1;
            }

            for(int i =0; i<a.Length; i++)
            {
                if (a[i] < 48 || a[i] > 59)
                {
                    //Console.WriteLine("Not valid integer");
                    //break;
                    return -1;
                }

                else
                {
                    output = output * 10 + a[i] - '0';
                }
            }

            //Console.WriteLine(output);
            return output;
        }
    }
}
