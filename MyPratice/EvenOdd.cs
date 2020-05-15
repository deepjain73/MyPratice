using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class EvenOdd
    {
        public void EvenorOdd()
        {
            int i = 20;
            if (i % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }
        }

        public void even()
        {
            int n = 37;
            for(int i=0; i<n; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public void odd()
        {
            int n = 36;
            for (int i = 1; i < n; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public void table()
        {
            int n = 60;
            for (int i = 5; i <= n; i += 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}

