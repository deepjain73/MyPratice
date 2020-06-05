using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyPratice
{
    class ImplementAStackUsingQueue
    {
        Queue q1, q2;
        

        public ImplementAStackUsingQueue()
        {
            q1 = new Queue();
            q2 = new Queue();

        }

        public void push(int data)
        {
            q1.Enqueue(data);
            
        }

        public int pop()
        {
            if (q1.Count == 0)
            {
                throw new Exception("No more itmes to return");
            }

            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }

            var popvalue = q1.Dequeue();

            while (q2.Count!= 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return (int)popvalue;
        }
    }

}
