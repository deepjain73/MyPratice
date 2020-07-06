using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Coding_Problem
{
    class Problem_1
    {
        //int[] s = new int[] { 10, 15, 3, 7 };

        public bool Findsum(int[] s)
        {
            int k = 17;
            //var c = 0;

            if (s.Length == 0 || s == null)
                return false;

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i+1; j < s.Length; j++)
                {
                   // c = s[i] + s[j];

                    if (s[i] + s[j] == k)
                        return true;
                }
            }

         return false;

        }

    }
}



//This problem was recently asked by Google.
//Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
//For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
//Bonus: Can you do this in one pass?
