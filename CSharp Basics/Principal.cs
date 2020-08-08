using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    class Principal : Inheriting, IPayroll
    {
        public void pay()
        {
            Console.WriteLine("Paying principal");
        }
    }
}
