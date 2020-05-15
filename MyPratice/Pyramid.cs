using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Pyramid
    {
      

        public void starpattern()
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        public void reversestarpattern()
        {
            int n = 5;
            for (int i = n; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
    
}
