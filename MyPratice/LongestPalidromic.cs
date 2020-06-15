using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class LongestPalidromic
    {


        public void findlps(string S)
        {
            int maxlength = 0, n = S.Length, startindex = 0, endindex = 0;

            for(int i=0; i<n; i++)
            {
                for(int j=i+1; j<=n-i; j++)
                {
                    if(palindrome(S.Substring(i,j)))
                    {
                        if(j-i > maxlength)
                        {
                            maxlength = S.Substring(i, j).Length;
                            startindex = i;
                            endindex = j;
                        }
                    }
                }
            }

            if (maxlength > 0)
            {
                Console.WriteLine(S.Substring(startindex, endindex) + " " + maxlength);
            }

            else
            { 
                Console.WriteLine("No longest palindromic substring found");
            }

        }


        public bool palindrome(string r)
        {
            for(int i=0,j=r.Length-1; i<r.Length/2; i++,j--)
            {
                if (r[i] != r[j])
                    return false;
            }
            return true;
        }
    }
}
