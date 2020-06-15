using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPratice
{
    class Reversestring
    {
        

        public void reversestring()
        {
            char[] c = new char[] { 'I', 'N', 'D', 'I', 'A' };
            int n = c.Length;

            for (int i = 0; i < n / 2; i++)
            {
                char temp = c[n-(i + 1)];
                c[n - (i + 1)] = c[i];
                c[i] = temp;
            }
            Console.WriteLine(c);

        }
    }
}
