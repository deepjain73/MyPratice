using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyPratice
{
    class RemoveDuplicates
    {
        char[] ch = new char[] { 'a', 'a','a', 'b', 'c', 'b', 'd', 'd' };
        Stack<char> s1 = new Stack<char>();
        Stack<char> s2 = new Stack<char>();



        public void FillStackS1()
        {
            char lastchar = '\0';            
            for(int i =0;i<ch.Length;i++)
            {
                if (lastchar != ch[i])
                    s1.Push(ch[i]);
                else
                {
                    s1.Pop();
                }    
                    
                lastchar = ch[i];
            }
        }
        public void CompareStacks()
        {
            bool NoMoreDups = false;
            while(true)
            {
                char lastchar = '\0';
                if (s1.Count > 0)
                {
                    char c = s1.Pop();
                    if (c != lastchar)
                        s2.Push(c);
                    lastchar = c;
                }
                else
                    break;

            }
        }
            
        public void removeduplicate()
        {
            FillStackS1();
            CompareStacks();
            
            //int i = 0;
            //char[] chNew = new char[ch.Length];
            //if (ch.Length == 0 || ch.Length == 1)
            //    return ;

            //if (currentcharIndex == ch.Length - 1)
            //    return;

            //if (ch[currentcharIndex] == ch[currentcharIndex + 1])
            //{
            //    while (i < ch.Length-1)
            //    {
            //        ch[i] = ch[i + 1];
            //        i++;
            //    }                
            //}
            //removeduplicate(currentcharIndex + 1);
            Console.WriteLine(ch);

        }

       
            
     }
}
