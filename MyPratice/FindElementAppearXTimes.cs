using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class FindElementAppearXTimes
    {
        public void findelement(int[]s,int x)
        {
            int result = -1;

            Dictionary<int, int> d = new Dictionary<int, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if(d.ContainsKey(s[i]))
                {
                    d[s[i]] = d[s[i]] + 1;
                }
                else
                {
                    d.Add(s[i], 1);
                }
            }

            foreach(var ele in d)
            {
                result = ele.Key;
                if(ele.Value == x)
                {
                    break;
                }
            }

            if(result == -1)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
