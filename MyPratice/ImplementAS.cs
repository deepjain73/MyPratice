using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    class ImplementAS // using queue
    {
        Queue q1, q2;

        public ImplementAS()
        {
            q1 = new Queue();
            q2 = new Queue();
        }

        public void push(int d)
        {
            q1.Enqueue(d);
        }

        public int pop()
        {
            if(q1.Count == 0)
            {
                throw new Exception("No more item to return");
            }

            while(q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }

            var p = q1.Dequeue();

            while(q2.Count != 0)
            {
                q1.Enqueue(q2.Dequeue());
            }

            return (int)p;
        }
    }
}
