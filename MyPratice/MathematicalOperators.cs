using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Schema;

namespace MyPratice
{
    class MathematicalOperators
    {
        
        int total;

        public void addmethod(int a, int b)
        {
            total = a + b;
            Console.WriteLine(total);
        }
        public void subtraction(int a, int b)
        {
            total = a - b;
            Console.WriteLine(total);
        }

       
     
    }
}
