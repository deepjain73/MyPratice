using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp_Basics
{
    public class Student : Inheriting
    {
        public static int count = 0;
        public int grade;
        public string birthday;
        public School school;
       
        public Student(string Name, int Grade, string Birthday, int Phone, string Address)
        {
            name = Name;
            grade = Grade;
            birthday = Birthday;
            phone = Phone;
            address = Address;
            
        }

        public Student()
        {

        }


    }
}
