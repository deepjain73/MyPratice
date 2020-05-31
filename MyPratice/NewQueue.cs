using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyPratice
{
    class NewQueue
    {
        public string[]array;
        public int tail;
        public int head;
        public int Capacity;


        public NewQueue()
        {
            array = new string[] { };
            head = 0;
            tail = 0;
        }

        public void Enqueue( string data)
        {
            if (tail == array.Length)
                SetCapacity();

            array[tail++] = data;

            Console.WriteLine("Item enqueue is: " + data);
            //for(int i=0;i<array.Length;i++)
            //{
            //    Console.WriteLine($"Items Enqueue are: " + array[i]);
            //}

            //foreach (var i in array)
            //    Console.Write(i);
            //Console.WriteLine();
        }


        public void SetCapacity()
        {
            if (array.Length == 0)
            {
                Capacity = 4;
                var newarray = new string[Capacity];
                array = newarray;
            }

            else
            {
                Capacity = array.Length * 2;
                var newarray = new string[Capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    newarray[i] = array[i];

                }
                array = newarray;
            }
        }

            public string Dequeue()
            {
            if (tail == 0)
                throw new Exception();

            var d = array[head];
            array[head++] = null;

            //for(int i =0;i<array.Length;i++)
            //{ Console.WriteLine("Items Dequeue are: " + d);}
            //return d;

            //foreach (var i in array)
            //    Console.Write(i);
            Console.WriteLine("Item enqueue is: " + d);

            return d;

        }
    }
}
