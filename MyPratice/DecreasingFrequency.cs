using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPratice
{
    class DecreasingFrequency
    {
        public void decreasingFrequency()
        {
            int[] arr = new int[] { 2, 5, 2, 8, 5, 6, 8, 8 };
            int n = arr.Length;

            if (n == 0 || n <= 1)
                Console.WriteLine("Array is empty");


            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i] = dic[i] + 1;
                }

                else dic.Add(i, 1);
            }

            //foreach (var k in dic)
            //{
            //    Console.WriteLine(k);
            //}

                var newdic = dic.OrderByDescending(d => d.Value);            
            foreach (var k in newdic)
            {
                for (int i = 0; i < k.Value; i++)
                    Console.Write(k.Key +" ");
            }

        }
    }     
}
