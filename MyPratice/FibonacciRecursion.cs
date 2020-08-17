using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyPratice
{
    class FibonacciRecursion
    {
        public int a;
        public int b;
        public int c;

        public FibonacciRecursion()
        {
            a = 0;
            b = 1;
        }

        public void fibonaaci(int n)
        {
            if(n>=0)
            Console.WriteLine(a);
            if(n>=1)
            Console.WriteLine(b);
           
           for (int i = 2; i < n; i++)
            {
                //c = a + b;
                Console.WriteLine(a + b + " ");
                
                b = a+b; //a=b;
                a = b-a; //b=c;
            }
            Console.WriteLine();
        }


        public int fib(int n)
        {
            if(n == 0 || n == 1)
            {               
                return n;
            }                
            else
            {
                return fib(n - 1) + fib(n - 2);
            }

        }
    }
}
