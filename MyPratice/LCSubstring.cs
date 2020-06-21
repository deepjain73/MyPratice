using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class LCSubstring
    {
        string X = "abcdxyz";
        string Y = "xyzabcd";

        public void findlcs()
        {
            int maxlength = 0, maxcurrentlen, startindex=0, endindex=0;

            if(X == null || Y == null)
                Console.WriteLine("String is empty");

            for(int i=0; i<X.Length ; i++)
            {
                for(int j=0; j<Y.Length; j++)
                {
                    if(X[i] == Y[j])
                    {
                        maxcurrentlen = 1;
                        if (maxlength == 0)
                            maxlength = 1;

                        for (int m = i + 1, n = j + 1; m < X.Length && n < Y.Length; m++, n++)
                        {
                            if (X[m] == Y[n])
                            {
                                maxcurrentlen = maxcurrentlen + 1;                      

                             if (maxcurrentlen > maxlength )
                                {
                                    maxlength = maxcurrentlen;
                                    startindex = i;
                                    endindex = m;
                                }
                            }
                            else
                            {
                                break;
                            }                           
                        }
                    }
                }
            }

            if (maxlength > 0)
            {
             Console.WriteLine("The longest common substring is"+ " " + X.Substring(startindex, endindex - startindex + 1) + " " + "and is of length"+ " " + maxlength);
            }

            else
            {
                Console.WriteLine("No match found");
            }
        }
    }
}
