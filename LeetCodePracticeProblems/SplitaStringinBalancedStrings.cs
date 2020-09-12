using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class SplitaStringinBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            int balance = 0, count = 0;

            for(int i = 0; i<s.Length; i++)
            {
                if(s[i] == 'L')
                {
                    balance++;
                }

                else
                {
                    balance--;
                }

                if (balance == 0)
                {
                    count++;
                }
            }

             return count;
        }
    }
}
