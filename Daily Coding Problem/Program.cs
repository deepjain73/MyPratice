using System;

namespace Daily_Coding_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem_1 p1 = new Problem_1();
            //int[] s = new int[] { 10, 15, 3, 7 };
            //Console.WriteLine(p1.Findsum(s));

            //Problem_2 p2 = new Problem_2();
            //p2.productofarray();

            Problem_3 p3 = new Problem_3();
            Problem_3.Node root = new Problem_3.Node("A");
            root.left = new Problem_3.Node("B");
            root.right = new Problem_3.Node("C");
            root.left.left = new Problem_3.Node("D");
            root.right.right = new Problem_3.Node("E");

            string s = p3.serialize(root);
            Console.WriteLine(s);
            

           


            //Problem_4 p4 = new Problem_4();

            //p4.findpositiveint();



        }
    }
}
