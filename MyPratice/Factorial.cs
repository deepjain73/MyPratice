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
    }
}
