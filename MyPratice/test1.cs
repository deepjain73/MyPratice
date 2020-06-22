
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class test1
    {
        public string radc(string s)
        {
           bool bfound = false;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    bfound = true;
                    break;
                }
            }

                if(bfound == true)
                {
                    s = removedup(s);
                }
                else
                
                    return s;
                
                return radc(s);
            }
        

        public string removedup(string c)
        {
            int startindex = 0, endindex = 0; bool bfoundendindex = false;

            for(int i = 0; i<c.Length-1; i++)
            {
                if (c[i] == c[i + 1])
                {
                    startindex = i;

                    for (int j = i; j < c.Length - 1; j++)
                    {
                        if (c[j] == c[j + 1])
                        {
                            if (j + 1 == c.Length - 1)
                            {
                                endindex = j + 1;
                                bfoundendindex = true;
                                break;
                            }

                            continue;
                        }
                        else
                        {
                            endindex = j;
                            bfoundendindex = true;
                            break;
                        }

                    }

                }

                if(bfoundendindex == true)
                {
                    break;
                }
            }

         
            return c.Remove(startindex, endindex + 1 - startindex);
        }

    }
}

