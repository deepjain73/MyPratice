using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class Number_of_pairs
    {
        public void findpairs(int[]X,int[]Y)
        {
            int count = 0;

            for(int i = 0; i<X.Length; i++)
            {
                for(int j = 0; j<Y.Length; j++)
                {
                    if(Math.Pow(X[i],Y[j]) > Math.Pow(Y[j],X[i]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
