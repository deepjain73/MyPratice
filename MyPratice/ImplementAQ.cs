using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ImplementAQ // using stack
    {
         Stack s1, s2;

        public ImplementAQ()
        {
            s1 = new Stack();
            s2 = new Stack();
        }

        public void enqueue(int d)
        {
            s1.push(d);
        }

        public int dequeue()
        {
            if (s1.tail == 0)
            {
                throw new Exception("No more itmes to return");
            }

            while(s1.tail != 0)
            {
                s2.push(s1.pop());
            }

            var p = s2.pop();

            while(s2.tail != 0)
            {
                s1.push(s2.pop());
            }

            return p;
        }
    }
}
