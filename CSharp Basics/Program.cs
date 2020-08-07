using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Survey sv = new Survey();

            Console.WriteLine("What is your name?");
            sv.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            sv.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            sv.Month = TryAnswer();

            sv.getdetails();

           
        }
        public static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("User didn't type anything. please type again.");
                return Console.ReadLine();
            }
            return answer;
        }

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

        //while (adding)
        //{
        //    Console.WriteLine("Name of the student:");
        //    studentnames.Add(Console.ReadLine());
        //    Console.WriteLine("Grade of the student:");
        //    studentgrades.Add(int.Parse(Console.ReadLine()));

        //    Console.WriteLine("Do you want to add more student? y/n");
        //    if (Console.ReadLine() != "y")
        //    {
        //        adding = false;
        //    }
        //}

        //for (int i = 0; i < studentgrades.Count; i++)
        //{
        //    Console.WriteLine("Student name is {0} and grade is {1}", studentnames[i], studentgrades[i]);
        //}

        //    Import();
        //    teaches();
        //    var student = new List<Student>();

        //    var adding = true;

        //    while (adding)
        //    {
        //        //Student newstudent = new Student("test",0,"28/7/2007",89,"34st");
        //        //Console.Write("Name of the student:");
        //        //newstudent.name = Console.ReadLine();

        //        Student newstudent = new Student();
        //        Teacher newteacher = new Teacher();

        //        newstudent.name = Util.Console.Askquestion("Name of the student:");
        //        newteacher.subject = Util.Console.Askquestion("Subject:");

        //        //Console.Write("Grade of the student:");
        //        //int grade = -1;
        //        //while(!int.TryParse(Console.ReadLine(), out grade))
        //        //{
        //        //    Console.WriteLine("Please input proper value for grade... :");
        //        //}
        //        //newstudent.grade = grade;
        //        newstudent.grade = int.Parse(Util.Console.Askquestion("Grade of the student:"));

        //        //Console.Write("Birthday of the student:");
        //        //newstudent.birthday = Console.ReadLine();
        //        newstudent.birthday = Util.Console.Askquestion("Birthday of the student:");

        //        //Console.Write("Address of the student:");
        //        //newstudent.address = Console.ReadLine();
        //        newstudent.address = Util.Console.Askquestion("Address of the student:");

        //        //Console.Write("Phone# of the student:");
        //        //int Phone = -1;
        //        //while(!int.TryParse(Console.ReadLine(), out Phone))
        //        //{
        //        //    Console.WriteLine("Please input proper value for phone... :");
        //        //}
        //        //newstudent.Phone = Phone;
        //        newstudent.Phone = int.Parse(Util.Console.Askquestion("Phone# of the student:"));

        //        student.Add(newstudent);
        //        Student.count++; // incrementing student count from class
        //        Console.WriteLine("Student count:{0}", Student.count);


        //        Console.WriteLine("Do you want to add more student? y/n");
        //        if (Console.ReadLine() != "y")
        //        {
        //            adding = false;
        //        }
        //    }

        //    foreach (var item in student)
        //    {
        //        Console.WriteLine("Student name is {0} and grade is {1}", item.name, item.grade);
        //    }


        //}

        //public static void Import()
        //{
        //    Student student1 = new Student("test", 0, "28/7/2007", 89, "34st");
        //    Console.WriteLine(student1.name +" "+ student1.grade);
        //}

        //public static void teaches()
        //{
        //    Teacher t1 = new Teacher("Maths");
        //    Console.WriteLine(t1.subject);
        //}



    }
}
