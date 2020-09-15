using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class ToLowerUpperCase
    {
        public string toLowerCase(string str)
        {
            string s = "";

            for(int i = 0; i<str.Length; i++)
            {
                if(str[i] > 64 && str[i] < 91)
                {
                    s = s + (char)(str[i] + 32);
                }

                else
                {
                    s = s + str[i];
                }
            }

            return s;
        }

        public string toUpperCase(string str)
        {
            string s = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 96 && str[i] < 122)
                {
                    s = s + (char)(str[i] - 32);
                }

                else
                {
                    s = s + str[i];
                }
            }

            return s;
        }
    }
}
