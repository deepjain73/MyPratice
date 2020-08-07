using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        public static string Askquestion(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
