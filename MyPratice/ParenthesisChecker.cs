using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPratice
{
    class ParenthesisChecker
    {
        public void check(string exp)
        {
            Stack<char> s = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    s.Push(exp[i]);
                }

                else if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (s.Count == 0)
                    {
                        Console.WriteLine("Not balanced");
                        return;
                    }

                    var p = s.Pop();

                    if ((p == '{' && exp[i] != '}') || (p == '(' && exp[i] != ')') || (p == '[' && exp[i] != ']'))
                    {
                        Console.WriteLine("Not balanced");
                        return;
                    }
                }

            }

            if (s.Count == 0)
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not balanced");

        }
    }
}

       
    

