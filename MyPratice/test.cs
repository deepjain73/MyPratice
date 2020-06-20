using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class test
    {
        string a = "amazon";
        string b = "azonam";

        public bool findroating(int shiftby)
        {
            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            var v = anticlockwise(b.ToCharArray(), shiftby);

            if (a == v)
                return true;
            else return false;

        }

        public string anticlockwise(char[]c,int shiftpositions)
        {
            for(int s =0; s< shiftpositions; s++)
            {
                char temp = c[0];
                for(int i = 0; i < c.Length-1; i++)
                {
                    c[i] = c[i + 1];
                }

                c[c.Length - 1] = temp;
            }

            return new string(c);
        }
    }
}
