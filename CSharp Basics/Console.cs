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

        public static int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {

                throw new FormatException("Input was not a number");
            }
          
        }
    }
}
