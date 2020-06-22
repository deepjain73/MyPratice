using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPratice
{
    public class URL_shortner
    {
       char[] cMap =  "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
       int baseNum = 62;

        public String encode(long num)
        {
            StringBuilder sb = new StringBuilder();

            while (num > 0)
            {
                sb.Append(cMap[num % baseNum]);
                num = num / baseNum;
            }


            StringBuilder builder = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                builder.Append(sb[i]);
            }
            return builder.ToString();
        }

        public long decode(String shortURL)
        {
            long id = 0; // initialize result  

            // A simple base conversion logic  
            for (int i = 0; i < shortURL.Length; i++)
            {
                if ('a' <= shortURL[i] && shortURL[i] <= 'z')
                    id = id * baseNum + shortURL[i] - 'a';
                if ('A' <= shortURL[i] && shortURL[i] <= 'Z')
                    id = id * baseNum + shortURL[i] - 'A' + 26;
                if ('0' <= shortURL[i] && shortURL[i] <= '9')
                    id = id * baseNum + shortURL[i] - '0' + 52;
            }
            return id;
        }
    }
}
