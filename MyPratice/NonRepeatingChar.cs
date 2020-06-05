using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPratice
{
    class NonRepeatingChar
    {
        public Dictionary<char, int> mydic;
        public int count;
        

        public NonRepeatingChar()
        {
            mydic = new Dictionary<char, int>();
            count = 0;
        }

        //public char nonrepeatingchar(char c)
        //{

        //    //int temp = 0;
        //    //foreach (char d in c.ToString())
        //    //{
        //    //    if (mydic.ContainsKey(c))
        //    //    {
        //    //        temp = mydic[c];
        //    //        mydic[c] = temp + 1;
        //    //        continue;
        //    //    }
        //    //    mydic.Add(c, 1);
        //    //}
        //    //if (mydic.ContainsValue(1))
        //    //{
        //    //    return mydic.First(x => x.Value == 1).Key;
        //    //}
        //    //return ' ';

        //    //if (c.count == 1)
        //    //    Console.WriteLine("1st non repeating element is " + c);

        //    //else
        //    //    Console.WriteLine("-1");

        //    if(mydic.ContainsKey(c)==false)
        //    {
        //        mydic.Add(c,1);
        //    }

        //    else
        //    {

        //    }

        //}
    }
}
