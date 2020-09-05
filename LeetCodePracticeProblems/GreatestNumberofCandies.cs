using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePracticeProblems
{
    class GreatestNumberofCandies
    {
        public void findgreatest(int[] s, int k)
        {
            int max = 0, t = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (max < s[i])
                {
                    max = s[i];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                t = s[i] + k;
                if (t >= max)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");

                }
            }



        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            IList<bool> il = new List<bool>();
            int max = 0, t = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                if (max < candies[i])
                {
                    max = candies[i];
                }
            }

            for (int i = 0; i < candies.Length; i++)
            {

                t = candies[i] + extraCandies;
                if (t >= max)
                {
                    il.Add(true);
                }
                else
                {
                    il.Add(false);
                }

            }
          return il;

        }
    }
}
