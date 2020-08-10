using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    class Logger
    {
        public const string defaultSystemName = "SchoolTracker";
        

        public static void log(string Msg,string System = defaultSystemName, int Priority=1)
        {
            //Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", System, Priority, Msg);
            Console.WriteLine($"System: {System}, Priority: {Priority}, Msg: {Msg}"); // string interpolation
        }
    }
}
