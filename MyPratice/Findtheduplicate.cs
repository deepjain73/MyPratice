using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Findtheduplicate
    {
        public void findduplicate(int[]d)
        {
            var carryover = 0;

            for(int i = 0; i<d.Length; i++)
            {
                carryover += d[i] - i;
            }
            Console.WriteLine(carryover);

        }
    }
}
