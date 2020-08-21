using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MyPratice
{
    public class MyQueue<T>
    {
        //static int capacity = 10, head = 0, tail = 0;

        //int[] queue = new int[capacity];
        //public int Enque(int i)
        //{
        //    queue[tail] = i;
        //    tail++;
        //    return tail;
        //}
        //public int Dque()
        //{
        //    return queue[head];           
        //}

        public T[] array;
        public int tail;
        public int head;
        public int Capacity;

        public MyQueue()
        {
            array = new T[] { }; 
            tail = 0;
            head = 0;
           
        }

        public void Enqueue(T data)
        {
            if(tail == array.Length)
            {
                SetCapacity();
            }
            //tail = (tail + 1) % array.Length;
            //array[tail] = data;


            array[tail++] = data;  //data is parameter coming in and incrementing tail
            //tail++;
            //tail = (tail + 1) % array.Length;  // reset tail to zero;

           // Console.WriteLine("Item enqueue is " + data);

            //foreach (var i in array)
            //    Console.Write(i);
            //Console.WriteLine();
        }

        public void SetCapacity()
        {
            if (array.Length == 0)
            {
                Capacity = 4; // setting capacity
                var newarray = new T[Capacity];  // new array
                array = newarray;  //pointing to new array
            }
            else
            {
                Capacity = array.Length * 2;
                var newarray = new T[Capacity];  // new array
                for (int i = 0; i < array.Length; i++)
                {
                    newarray[i] = array[i];  //copy old array into new and if array length is greater than 0
                }
                array = newarray;  //pointing to new array
            }
            
        }

        public T Dequeue()  // return data back
        {
            if (tail == 0)
                throw new IndexOutOfRangeException();  // nothing to dequeue

            var d = array[head];   // copy head data into new variable
            
            array[head++] = default(T);  // nullify
            //foreach (var i in array)
            //Console.Write(i);
            Console.WriteLine("Item dequeue is: " + d);
            return d;
           
        }

       
    }

    
}


//complexity O(n);