using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyPratice
{
    class Palindrome
    {
        //string[] S = new string[] { };

        public void palindrome(string T)
        {
            for(int i= 0,j=T.Length-1; i<=T.Length/2; i++,j--)
            {
               if(T[i] != T[j])
                {
                    Console.WriteLine("Is not palindrome");

                    break;
                }
             }
            Console.WriteLine("Is palindrome");
        }
    }
}
