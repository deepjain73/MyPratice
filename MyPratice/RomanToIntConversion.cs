using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyPratice
{
    class RomanToIntConversion
    {
        
        public int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }

        public void romantoint(string s)
        {
             int result = 0; 

            for(int i=0; i<s.Length;i++)
            {
               int a = value(s[i]);

                if (i + 1 < s.Length)
                {
                    int b = value(s[i + 1]);

                    if (a >= b)
                    {
                        result = result + a;
                    }
                    else
                    {
                        result = result + b - a;
                        i++;
                    }
                }

                else
                {
                    result = result + a;
                    i++;
                }

             }
            Console.WriteLine(result);
        }
    }
}
