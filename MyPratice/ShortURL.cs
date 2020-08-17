using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ShortURL
    {
        int id = 650;
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        public string getshortURL(string url)
        {
            if(myDict.ContainsKey(url))
            {
                return "www.bit.ly/" + myDict[url].ToString();
            }
            else
            {
                id = id + 1;
                var shorturl = encode(id);
                myDict.Add(url, shorturl);
                return "www.bit.ly/" + shorturl;
            }
        }

        private string encode(int id)
        {
            string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int baselenght = 64;
            StringBuilder sb = new StringBuilder();
            while(id > 0)
            {
                var mynum = id % baselenght;
                sb.Append(characters[mynum]);
                id = id / baselenght;
            }
            return sb.ToString();
        }
    }
}
