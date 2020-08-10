using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTool
{
    class Square : Shape
    {
        private int Width;

        public int MyWidth
        {
            get {
                return Width;
            }
            set
            {
                Width = value;
            }
        }

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
 