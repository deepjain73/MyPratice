using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTool
{
    class Square : Shape
    {
        public int Width;

        //public override getarea()
        //{
        //    return Width * Width;
        //}

        public override int getarea()
        {
            return Width * Width;
        }
    }
}
