using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public static class Extensionsmethods
    {
        public static int toint(this string value) // this is reference variable that points to itself, or to its own object. string is data type
        {
            return int.Parse(value);
        }
    }
    class Console
    {
        public static string Askquestion(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        public static string Askquestion(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return System.Console.ReadLine().toint(); // toint is extension method
            }
            catch (Exception)
            {

                throw new FormatException("Input was not a number");
            }
          
        }
    }
}
