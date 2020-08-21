using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Findtheresult
    {
        public bool findresult(int[] a, int target)
        {
            if (a == null || a.Length <= 1)
                return false;
            
                int sum = 0;

            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                sum = target - a[i];

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (d.ContainsKey(sum - a[j]))
                    {
                        Console.WriteLine("vlaue = " + a[i] + "," + a[j] + "," + (sum - a[j]).ToString());
                        return true;
                    }


                    d.Add(a[j], 1);
                }

            }
            return false;
        }
    }
       
}
