using System;

namespace GeometryTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square() { MyWidth = 2 };
            
            Triangle tr = new Triangle() { Base = 3, Heigth = 5 };
            //Console.WriteLine(tr.getarea());
            //Console.WriteLine(sq.getarea());
            sq.dispaly();
            tr.dispaly();
        }
    }
}
