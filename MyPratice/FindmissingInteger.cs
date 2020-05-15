using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class FindmissingInteger
    {
        public void missinginteger()
        {
            int[] m = new  int[]{1,3,4,5,6,7};
            Boolean bfound = false;
            int Exceptedsum; int min = m[0];

           for(int i = 0; i<m.Length; i++)
            {
                Exceptedsum = min + i;
                if (Exceptedsum != m[i])
                {
                    bfound = true;
                    Console.WriteLine($"Missing Number is  { Exceptedsum}");
                    break;
                }
            }
            if (bfound == false)
            Console.WriteLine("No missing number");
          
        }
    }
}
