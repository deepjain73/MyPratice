using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    public class Teacher : Inheriting,IPayroll
    {
        public string subject;

        public Teacher(string Subject)
        {
            subject = Subject;
        }

        public Teacher()
        {

        }

        public void pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
   
