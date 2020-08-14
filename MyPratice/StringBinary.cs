using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class StringBinary
    {
        public int TitleToNumber(string s)
        {
            if (s == null || s.Length == 0)
                return -1;
            double sum = 0;
            double power = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //Ascii value of A is 65 and we need A=1 and Z=26
                double tmp = ((double)s[i]) - 64;
                sum = sum + (tmp * (Math.Pow(26.0, power)));               
                power++;
            }
            return (int)sum;

        }
        public int BinaryToNumber(string s)
        {
            if (s == null || s.Length == 0)
                return -1;
            double sum = 0;
            double power = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //Ascii value of 0 is 48 and 1 is 49
                double tmp = ((double)s[i]) - 48;
                sum = sum + (tmp * (Math.Pow(2.0, power)));               
                power++;
            }
            return (int)sum;

        }

        public void NumberToBinary(int n)
        {
            string s = "";

            while(n != 0)
            {
                int p = n % 2;
                n = n / 2;
                s = p + s;
            }

            Console.WriteLine(s);

        }
    }
}
