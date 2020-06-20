using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyPratice
{
    class ImplementStrStr
    {
        string s = "the whole world is mad mad and i am best";
        string x = "is mad";

        public string strstr()
        {
            int startindex = 0;
            bool bFound = false;
            for (int i = 0; i < s.Length && bFound == false; i++)
            {
                for (int j = 0; j < x.Length && !bFound; j++)
                {
                    if (x[j] == s[i])
                    {
                        startindex = i;
                        for (int m = i + 1, n = j + 1; m < s.Length && n < x.Length; m++, n++)
                        {
                            if (x[n] == s[m])
                            {
                                if (n == x.Length - 1)
                                {
                                    bFound = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (startindex > 0)
            {
                return s.Substring(startindex, s.Length - startindex);
            }
            else
            {
                return "-1";
            }
        }
    }
}

        



        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        int start = i;
        //        int j = 0;
        //        while (i < s.Length && j < x.Length && s[i] == x[j])
        //        {
        //            i++;
        //            j++;
        //        }

        //        if (j == x.Length)
        //        {
        //            return i-x.Length;
        //        }

        //        i = start;
        //    }

        //    return -1;
        //}
    
    




