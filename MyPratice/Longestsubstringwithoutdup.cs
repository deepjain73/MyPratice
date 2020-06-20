using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPratice
{
    class Longestsubstringwithoutdup
    {
        string s = "abca";
        Dictionary<char, int> mydic = new Dictionary<char, int>();

        public void findlswithoutdup()
        {
            int maxlength = 1, startindex = 0, endindex = 0;

            for(int i =0; i < s.Length; i++)
            {
                for(int j = i; j < s.Length; j++)
                {
                    if(mydic.ContainsKey(s[j]))
                    {
                        mydic.Clear();
                        break;
                    }

                    else
                    {
                        mydic.Add(s[j], 1);
                            if(maxlength < (j-i+1))
                        {
                            maxlength = j - i + 1;
                            startindex = i;
                            endindex = j;

                        }
                    }
                }
            }

            Console.WriteLine(s.Substring(startindex, endindex+1) + " " + maxlength);


            //if (s[i] == s[i + 1])
            //{
            //    var prev = s[i - 1];

            //    for (int j = i; j > 0; j--)
            //    {
            //        if (s[i] != s[j])
            //        {
            //            maxcurrlen = maxcurrlen + 1;
            //            break;
            //        }

            //        else
            //        {

            //        }

            //        if (maxcurrlen > maxlength)
            //        {
            //            maxlength = maxcurrlen;
            //            startindex = i;
            //            endindex = j;

            //        }
            //    }
            //}



        }
    }
}
