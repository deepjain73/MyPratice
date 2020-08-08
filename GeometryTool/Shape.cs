using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTool
{
    abstract class Shape
    {
        public abstract int getarea();

        public void dispaly()
        {
            Console.WriteLine("The area is {0}", getarea());
        }
        
    }
}
