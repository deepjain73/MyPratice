using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class MergeArray
    {
        public void mergearray(int[]s,int[] b)
        {
            for(int i = 0,j=0; i<s.Length && j<b.Length;i++,j++)
            {
                if(s[i] > b[j])
                {
                    int temp = s[i];
                    s[i] = b[j];
                    b[j] = temp;
                }
                
            }
        }
    }
}
