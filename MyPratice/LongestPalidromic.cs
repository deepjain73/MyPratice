using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyPratice
{
    class LongestPalidromic
    {


        public void findlps(string S)
        {
            int maxlength = 0, n = S.Length, startindex = 0, endindex = 0;

            if (S.Length == 0 || S.Length <= 1)
                Console.WriteLine("Array is empty");

            for(int i=0; i<n;i++)
            {
                for(int j=i+1; j<=n-i; j++)
                {
                    if(ispalindrome(S.Substring(i,j)))
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
                Console.WriteLine("The longerst palindromic substring in S is " + S.Substring(startindex,endindex) + " " + maxlength);

            else
                Console.WriteLine(" No longest palindromic substring in S found");

        }
        
        public bool ispalindrome(string c)
        {
            for(int i=0,j=c.Length-1; i<c.Length/2; i++,j--)
            {
                if (c[i] != c[j])
                    return false;
            }

            return true;
        }

        





            
    }
}
