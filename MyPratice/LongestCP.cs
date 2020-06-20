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
        string[] N = { "appele", "appe", "apperil" };

        Dictionary<string, int> mydic = new Dictionary<string, int>();


        public void findlcp()
        {
            foreach (var i in N)
            {
                StringBuilder sbTemp = new StringBuilder();
                foreach (char c in i)
                {
                    sbTemp.Append(c);
                    if (mydic.ContainsKey(sbTemp.ToString()))                    
                        mydic[sbTemp.ToString()] = mydic[sbTemp.ToString()] + 1;                    
                    else                    
                        mydic.Add(sbTemp.ToString(), 1);
                }
            }
            var maxvalue = mydic.Values.Max();
            //var result = mydic.Where(d => d.Value == 5).OrderByDescending(d => d.Key.Length).FirstOrDefault();
            var maxlength = 0;
            string result = "";
            foreach (var k in mydic.Where(d => d.Value == maxvalue))
            {
                if (k.Key.Length > maxlength)
                {
                    result = k.Key;
                    maxlength = result.Length;
                }
            }
            Console.WriteLine("Longest frequent substring is :" + result);
        }

        //public void findmaxlength()
        //{
        //    if( > 3)
        //    {

        //    }

        //}
    }
}
