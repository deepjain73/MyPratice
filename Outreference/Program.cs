using System;

namespace Outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "a"; var y = "b";
            var a = 2; var b = 9;

            Console.WriteLine(a);
            number(out a);
            Console.WriteLine(a);
            doublesum(ref a);
            Console.WriteLine(a);

            addanything(a, b);
            addanything(x,y);
        }

        static void number(out int n)
        {
            n = 5;
            Console.WriteLine(n);
        }

        static void doublesum(ref int n)
        {
            n = n*2;
            Console.WriteLine(n);
        }

        public static void addanything(int a, int b)
        {
            var total = a + b;
            Console.WriteLine(total);
        }

        public static void addanything(string a, string b)
        {
            var total = a + b;
            Console.WriteLine(total);
        }
    }
}
