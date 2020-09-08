using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0 ;

            for(int i = 0; i<J.Length; i++)
            {
                for(int j = 0; j<S.Length; j++)
                {
                    if(J[i] == S[j])
                    {
                        count++;
                    }
                }
            }

            if(count>0)
            {
                return count;
            }

            else
            {
                return 0;
            }
        }
    }
}
