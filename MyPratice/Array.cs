using System;
using System.Collections.Generic;
using System.Text;

namespace MyPratice
{
    public class Array
    {
       int[] rollno;
       public void SetArray()
        {
            rollno = new int[10]; /*{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };*/   //array initailization
            rollno[0] = 1;
            rollno[1] = 2;
            rollno[2] = 3;
            rollno[3] = 4;
            rollno[4] = 5;
            rollno[5] = 6;
            rollno[6] = 7;
            rollno[7] = 8;
            rollno[8] = 9;
            rollno[9] = 10;

           // for (int i = 0; i < 10; Console.WriteLine(i), i++);
        }

        public void LoopThroughArray()
        {
            // for loop:
            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine(rollno[i]);
            }

            ////foreach:
            foreach (int ii in rollno)
                Console.WriteLine(ii);

            ////while loop:
            int i1 = 0;
            while (i1 < rollno.Length)
            {
                Console.WriteLine(rollno[i1]);
                i1++;
            }

            ///do while loop:
            Console.WriteLine("Now doing do while loop");
            int di = 0;
            do
            {
                Console.WriteLine(rollno[di]);
                di++;
            }
            while (di < rollno.Length);

            //   

            // for loop:
            Console.WriteLine("for loop");
            string[] daysofweek = new string[7] { "Sunday", "ronday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            for (int i = 0; i < daysofweek.Length; i++)
            {
                Console.WriteLine(daysofweek[i]);
            }

            // for each loop:
            Console.WriteLine("for each");
            foreach (string i in daysofweek)
                Console.WriteLine(i);

        }

        string[] name = new string[6] { "D", "E", "E", "P", "T", "I" };
        public void namearray()
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

            public void nameprint(string name)
        {
            Console.WriteLine("Hello" + " " + name);
        }

        public void reversename()
        {
            for(int i=name.Length-1; i>=0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }

    }
}
