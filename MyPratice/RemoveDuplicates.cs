using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyPratice
{
    class RemoveDuplicates
    {
       public string removeDups(string input)
        {
            bool bDupFound = false;
            for(int i =1; i<input.Length;i++)
            {
                if (input[i - 1] == input[i])
                {
                    bDupFound = true;
                    break;                   
                }                
            }
            if (bDupFound == true)
            {
                input = removeContinousDups(input);
            }
            else
            {
                return input;
            }
            return removeDups(input);
        }
      

        public string removeContinousDups(string ch)
        {
            int startindex = 0, endindex = 0;
            bool bFoundEndIndex = false;

            for (int i = 0; i < ch.Length - 1; i++)
            {
                if (ch[i] == ch[i + 1])
                {
                    startindex = i;

                    for (int j = i; j < ch.Length - 1; j++)
                    {
                        if (ch[j] == ch[j + 1])
                        {
                            if (j + 1 == ch.Length - 1)
                            {
                                endindex = j + 1;
                                bFoundEndIndex = true;
                                break;
                            }
                            continue;
                        }
                        else
                        {
                            endindex = j;
                            bFoundEndIndex = true;
                            break;
                        }
                    }
                }
                if (bFoundEndIndex == true)
                    break;
            }
            var t = new string(ch);
            return t.Remove(startindex, endindex + 1 - startindex);

        }


    }
}
