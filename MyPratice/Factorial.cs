using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Factorial
    {
        public int Fact(int n)
        {
            if (n == 1)
                return n;
           return n * Fact(n - 1);
        }

        public int facto(int n)
        {
            int output = 1;
            for(int i = 1; i<= n;i++)
            {
                output = output * i;
               // Console.WriteLine(output);
            }

            return output;
            
        }
    }
}
