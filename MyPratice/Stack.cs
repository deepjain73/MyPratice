using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyPratice
{
    class Stack
    {
        public int tail;
        public int[] array;
        public int Capacity;

        public Stack()
        {
            array = new int[] { };
            tail = 0;
        }

        public void push(int data)
        {
            if (tail == array.Length)
            {
                SetCapacity();
            }

            array[tail++] = data;
            //Console.WriteLine("Item push is:" + data);
        }

        public void SetCapacity()
        {
            if (array.Length == 0)
            {
                Capacity = 4;
                var newarray = new int[Capacity];
                array = newarray;
            }

            else
            {
                Capacity = array.Length * 2;
                var newarray = new int[Capacity];

                for (int i = 0; i < array.Length; i++)
                {
                    newarray[i] = array[i];
                }
                array = newarray;
            }
        }

        public int pop()
        {
            if(tail==0)
            { throw new Exception("No more itmes"); }

            var d = array[--tail];
            array[tail] = default(int);

            //Console.WriteLine("Item pop is :" + d);
            return d;
        }

            
        }
       
}

