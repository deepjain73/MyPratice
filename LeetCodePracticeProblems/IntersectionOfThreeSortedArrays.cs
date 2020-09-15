using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class IntersectionOfThreeSortedArrays
    {
        public void FindIntersection(int[]a,int[]b,int[]c)
        {
            for(int i = 0; i<a.Length; i++)
            {
                for(int j = 0; j<b.Length; j++)
                {
                    if(a[i] == b[j])
                    {
                        for(int k = 0; k<c.Length; k++)
                        {
                            if(b[j] == c[k])
                            {
                                Console.WriteLine(a[i]);
                            }
                        }
                    }
                }
            }
        }

        public void findIntersection(int[] a, int[] b, int[] c)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach(var i in a)
            {
                if(! d.ContainsKey(i))
                {
                    d.Add(i, 1);
                }
            }

            foreach(var j in b)
            {
                if(d.ContainsKey(j))
                {
                    d[j] = d[j] + 1;
                }
                else
                {
                    d.Add(j, 1);
                }
            }

            foreach (var k in c)
            {
                if (d.ContainsKey(k))
                {
                    d[k] = d[k] + 1;
                }
                else
                {
                    d.Add(k, 1);
                }
            }

            foreach(var l in d)
            {
                if(l.Value > 2)
                {
                    Console.WriteLine(l.Key);
                }
            }
        }
    }
}
