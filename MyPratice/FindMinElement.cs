using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MyPratice
{
    class FindMinElement
    {
        Stack s; int currentmin;

        public FindMinElement()
        {
            s = new Stack();
        }

       public int getmin()
        {
            if (s.tail == 0)
                throw new Exception("Stack is empty");

            return currentmin;
        }

       public void push(int data)
        {
            if (s.tail == 0)
            {
                currentmin = data;
            }

            if (data < currentmin)
            {
                currentmin = data;
            }

            s.push(data);
        }

        public int pop()
        {
            if (s.tail == 0)
                throw new Exception("Stack is empty");

            var m = s.pop();

            if( m < currentmin)
            {
                currentmin = m;
            }

            return m;
        }
        
    }
}
