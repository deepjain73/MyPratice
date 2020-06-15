﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class RotatingString
    {     

        public bool rotatestring(string a, string b, int shiftby)
        {

            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            var t = shiftClockWise(a.ToCharArray(), shiftby);
            var v = shiftAnticlockwise(a.ToCharArray(), shiftby);           

            if (b == t || b==v)
                return true;
            else
                return false; 
        }

        public string shiftClockWise(char[] ch, int shiftpositions)
        {
            int n = ch.Length;
            for (int s = 0; s < shiftpositions; s++)
            {              
                char tmp = ch[n - 1];
                for (int i = n - 2; i >= 0; i--)
                {
                    ch[i + 1] = ch[i];
                }
                ch[0] = tmp;
            }
            return new string(ch);
        }

        public string shiftAnticlockwise(char[]ch,int shiftpositions)
        {
            int n = ch.Length;
            for (int s = 0; s < shiftpositions; s++)
            {
                char tmp = ch[0];
                for (int i = 0; i<n-1;i++)
                {
                    ch[i] = ch[i + 1];
                }
                ch[n-1] = tmp;
            }
            return new string(ch);
        }       
    }
}
