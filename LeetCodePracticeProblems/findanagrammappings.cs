using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class findanagrammappings
    {
        public void findanamap(int[] a, int[] b)
        {
           if( a.Length != b.Length)
            {
                Console.WriteLine("Anagram not found");
            }

            int[] arr = new int[a.Length];

            for(int i = 0; i<a.Length; i++)
            {
                for(int j = 0; j<b.Length; j++)
                {
                    if(a[i] == b[j])
                    {
                        arr[i] = j;
                        Console.WriteLine(arr[i]);
                    }
                }
            }

        }
    }
}
