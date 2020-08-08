using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTool
{
    class Triangle : Shape
    {
        public int Heigth;
        public int Base;

        //public override getarea()
        //{
        //    return (Heigth * Base)/2;
        //}

        public override int getarea()
        {
            return (Heigth * Base) / 2;
        }
    }
}
