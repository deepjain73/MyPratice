using System;
using System.Collections.Generic;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("What is your name?");
            //    var name = TryAnswer();

            //    Console.WriteLine("What is your age?");
            //    var age = TryAnswer();

            //    Console.WriteLine("What month were you born in?");
            //    var month = TryAnswer();

            //    Console.WriteLine("Your name is {0}.", name);
            //    Console.WriteLine("You are {0} years old.", age);
            //    Console.WriteLine("You were born in {0} month.", month);

            //    if (month == "October")
            //    {
            //        Console.WriteLine("Your zodiac sign is Libra.");
            //    }
            //    else if (month == "December")
            //    {
            //        Console.WriteLine("Your zodiac sign is Sagittarius.");
            //    }
            //    else if (month == "July")
            //    {
            //        Console.WriteLine("Your zodiac sign is Cancer.");
            //    }

            //var Passcode = "";

            //while (Passcode != "secret")
            //{
            //    Console.WriteLine("What is the pascode?");

            //     Passcode = Console.ReadLine();
            //   if (Passcode != "secret")
            //    {
            //        Console.WriteLine("User is not authenticated.");
            //    }
            //}
            //Console.WriteLine("User is authenticated.");

            //var count = 1;
            //while(count <= 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //LoopCounting

            //var count = 1;
            //while (count <= 5)
            //{
            //    Console.WriteLine("Count# {0}:",count);
            //    count++;

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // School Tracker

            //var studentsGrades = new int[] { 30, 25, 40, 35, 50, 60, 45, 76, 80, 54, 36 };
            //for (int i = 0; i < studentsGrades.Length; i++)
            //{
            //    Console.WriteLine(studentsGrades[i]);
            //}

            //foreach (var i in studentsGrades)
            //{
            //    Console.WriteLine(i);
            //}



            //}

            //public static string TryAnswer()
            //{
            //    var answer = Console.ReadLine();
            //    if (answer == "")
            //    {
            //        Console.WriteLine("User didn't type anything. please type again.");
            //        return Console.ReadLine();
            //    }
            //    return answer;
            //}

            //JobCandidate
            //Console.WriteLine("How many years of experience do you have?");
            //var years = int.Parse(Console.ReadLine());

            //switch(years)
            //{
            //    case 0:
            //        Console.WriteLine("Inexperienced");
            //        break;
            //    case 1:
            //        Console.WriteLine("Junior");
            //        break;
            //    case 2:
            //        Console.WriteLine("Intermediate");
            //        break;
            //    case 3:
            //        Console.WriteLine("Advanced");
            //        break;
            //    default:
            //        Console.WriteLine("Senior");
            //        break;
            //}

            //if(years == 0)
            //{
            //    Console.WriteLine("Inexperienced");
            //}
            //else if (years == 1)
            //{
            //    Console.WriteLine("Junior");
            //}
            //else if (years == 2)
            //{
            //    Console.WriteLine("Intermediate");
            //}
            //else if (years == 3)
            //{
            //    Console.WriteLine("Advanced");
            //}
            //else
            //{
            //    Console.WriteLine("Senior");
            //}


            // StudentManager

            // Console.WriteLine("How many students in the class?");
            // var count = int.Parse(Console.ReadLine());

            // var names = new string[count];
            // var grades = new int[count];

            // for(int i = 0; i<count; i++)
            // {
            //     Console.WriteLine("Name of the student:");
            //     names[i] = Console.ReadLine();
            //     Console.WriteLine("Grade of the student:");
            //     grades[i] = int.Parse(Console.ReadLine());
            // }

            //for(int i = 0; i < count; i++)
            // {
            //     Console.WriteLine("Student name is {0} and Grade is {1}", names[i], grades[i]);
            // }

            // List

            //var studentnames = new List<string>();
            //var studentgrades = new List<int>();
            //var adding = true;

            //while(adding)
            //{
            //    Console.WriteLine("Name of the student:");
            //    studentnames.Add(Console.ReadLine());
            //    Console.WriteLine("Grade of the student:");
            //    studentgrades.Add(int.Parse(Console.ReadLine()));

            //    Console.WriteLine("Do you want to add more student? y/n");
            //    if(Console.ReadLine() != "y")
            //    {
            //        adding = false;
            //    }
            //}

            //for(int i = 0; i < studentgrades.Count; i++)
            //{
            //    Console.WriteLine("Student name is {0} and grade is {1}", studentnames[i], studentgrades[i]);
            //}

            var student = new List<Student>();
            var adding = true;

            while(adding)
            {
                Student newstudent = new Student();
                Console.Write("Name of the student:");
                newstudent.name = Console.ReadLine();

                Console.Write("Grade of the student:");
                int grade = -1;
                while(!int.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("Please input proper value for grade... :");
                }
                newstudent.grade = grade;

                Console.Write("Birthday of the student:");
                newstudent.birthday = Console.ReadLine();


                Console.Write("Address of the student:");
                newstudent.address = Console.ReadLine();


                Console.Write("Phone# of the student:");
                newstudent.phone = int.Parse(Console.ReadLine());

                student.Add(newstudent);


                Console.WriteLine("Do you want to add more student? y/n");
                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var item in student)
            {
                Console.WriteLine("Student name is {0} and grade is {1}",item.name,item.grade);
            }


        }
    }
}
