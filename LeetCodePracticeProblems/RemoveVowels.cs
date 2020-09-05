using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class RemoveVowels
    {
        public void removevow(string s)
        {
            string d = "";

            for(int i =0; i<s.Length; i++)
            {
                if ((s[i] == 'a') || (s[i] == 'e') || (s[i] == 'i') || (s[i] == 'o') || (s[i] == 'u'))
                {
                    d = d + "";
                }

                else
                {
                    d = d + s[i];
                }

                

                
            }
            Console.WriteLine(d);
        }
    }
}
