using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MyPratice
{
    class CountFrequencyUsingDictionaMy
    {
        public void CalcFreq()
        {
            int[] arr = new int[] { 2, 5, 2, 8, 5, 6, 8, 8 };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in arr)

            {
                if (dic.ContainsKey(i))
                    dic[i] = dic[i] + 1;
                else
                    dic.Add(i, 1);
            }
            foreach (var k in dic)
            {
                Console.WriteLine(k);
            }

            var newdic = dic.OrderByDescending(x => x.Value);
            foreach (var k in newdic)
            {
                Console.WriteLine(k);
            }


        }
    }
}
