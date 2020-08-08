using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Basics
{
    class Survey
    {
        public string Name;
        public int Age;
        public string Month;

        public Survey()
        {

        }

        public void getdetails()
        {
            Console.WriteLine("Your name is {0}.", Name);
            Console.WriteLine("You are {0} years old.", Age);
            Console.WriteLine("You were born in {0} month.", Month);

            switch (Month)
            {
                case "July":
                    Console.WriteLine("Your zodiac sign is Cancer.");
                    break;
                case "October":
                    Console.WriteLine("Your zodiac sign is Libra.");
                    break;
                case "December":
                    Console.WriteLine("Your zodiac sign is Sagittarius.");
                    break;
                default:
                    Console.WriteLine("Given month is not in list");
                    break;
            }


            
            //if (Month == "October")
            //{
            //    Console.WriteLine("Your zodiac sign is Libra.");
            //}
            //else if (Month == "December")
            //{
            //    Console.WriteLine("Your zodiac sign is Sagittarius.");
            //}
            //else if (Month == "July")
            //{
            //    Console.WriteLine("Your zodiac sign is Cancer.");
            //}
        }

    }
}
