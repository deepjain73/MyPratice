using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Markup;

namespace MyPratice
{
    class LongestCP
    {
        string[] N = { "apple", "ape", "april" };

        Dictionary<string, int> dic = new Dictionary<string, int>();


        public void findlcp()
        {
            foreach (var i in N)
            {
                StringBuilder sbTemp = new StringBuilder();
                foreach (char c in i)
                {
                    sbTemp.Append(c);
                    if (dic.ContainsKey(sbTemp.ToString()))                    
                        dic[sbTemp.ToString()] = dic[sbTemp.ToString()] + 1;                    
                    else                    
                        dic.Add(sbTemp.ToString(), 1);
                }
            }
            var maxvalue = dic.Values.Max();
            //var result = mydic.Where(d => d.Value == 5).OrderByDescending(d => d.Key.Length).FirstOrDefault();
            var maxlength = 0;
            string result = "";
            foreach (var k in dic.Where(d => d.Value == maxvalue))
            {
                if (k.Key.Length > maxlength)
                {
                    result = k.Key;
                    maxlength = result.Length;
                }
            }
            Console.WriteLine("Longest frequent substring is " + result + " and maxlength is " + maxlength);
        }

        //public void findmaxlength()
        //{
        //    if( > 3)
        //    {

        //    }

        //}
    }
}
