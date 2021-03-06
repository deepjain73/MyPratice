﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Basics
{
    public enum School
    {
        Bennet,
        Tillicum,
        Interlake,
    }
    class Program
    {
        public static event Action Posted;
        static List<Student> student = new List<Student>();
        static void Main(string[] args)
        {

            //   var sv = new Survey();
            //    var st = new Stats();
            //    st.start();

            //    Console.WriteLine("What is your name?");
            //    sv.Name = TryAnswer();

            //    Console.WriteLine("What is your age?");
            //    sv.Age = int.Parse(TryAnswer());

            //    Console.WriteLine("What month were you born in?");
            //    sv.Month = TryAnswer();

            //    if(Posted != null)
            //    {
            //        Posted();
            //    }


            //    sv.getdetails();


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


            //Import();
            //teaches();


        var adding = true;
        Student newstudent = new Student();
        Teacher newteacher = new Teacher();
        Payroll payroll = new Payroll();
        Logger.log("Tracker started",Priority:0);
        payroll.payall();

            while (adding)
            {
               try
                {
                    Logger.log("Adding new student");
                    newstudent.name = Util.Console.Askquestion("Name of the student:");
                    newstudent.grade = Util.Console.AskInt("Grade of the student:");
                    newstudent.school = (School) Util.Console.AskInt("School name(Select option from the list): \n 0:Bennett \n 1:Tillicum \n 2:Interlake \n");
                    newstudent.birthday = Util.Console.Askquestion("Birthday of the student:");
                    newstudent.address = Util.Console.Askquestion("Address of the student:");
                    newstudent.phone = Util.Console.AskInt("Phone# of the student:");

                    student.Add(newstudent);
                    Student.count++; // incrementing student count from class
                    Console.WriteLine("Student count:{0}", Student.count);


                    Console.WriteLine("Do you want to add more student? y/n");
                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
               }

                catch(FormatException f)
                {
                    Console.WriteLine(f.Message);
                }

                catch (Exception)
                {

                    Console.WriteLine("Please provide correct input....");
                }
            }

            Showgrade("John"); 

            foreach (var item in student)
            {
                Console.WriteLine("Student name is {0} and grade is {1}", item.name, item.grade);
            }

            Exports();


        }

        public static void Import()
{
    Student student1 = new Student("test", 0, "28/7/2007", 89, "34st");
    Console.WriteLine(student1.name + " " + student1.grade);
}

        public static void Exports()
{
    foreach (var item in student)
    {
        switch (item.school)
        {
            case School.Bennet:
                Console.WriteLine("Exporting from Bennet.");
                break;
            case School.Tillicum:
                Console.WriteLine("Exporting from Tillicum.");
                break;
            case School.Interlake:
                Console.WriteLine("Exporting from Interlake.");
                break;

        }
    }
}

        public static void Showgrade(string name)
        {
            var found = student.Find(student => student.name == name); // for filter
            Console.WriteLine("{0}'s grade is {1}", found.name, found.grade);
        }

        //public static void teaches()
        //{
        //    Teacher t1 = new Teacher("Maths");
        //    Console.WriteLine(t1.subject);
        //}

        //Student newstudent = new Student("test",0,"28/7/2007",89,"34st");
        //Console.Write("Name of the student:");
        //newstudent.name = Console.ReadLine();
        //newteacher.subject = Util.Console.Askquestion("Subject:");

        //Console.Write("Grade of the student:");
        //int grade = -1;
        //while(!int.TryParse(Console.ReadLine(), out grade))
        //{
        //    Console.WriteLine("Please input proper value for grade... :");
        //}
        //newstudent.grade = grade;
        //Console.Write("Birthday of the student:");
        //newstudent.birthday = Console.ReadLine();


        //Console.Write("Address of the student:");
        //newstudent.address = Console.ReadLine();


        //Console.Write("Phone# of the student:");
        //int Phone = -1;
        //while(!int.TryParse(Console.ReadLine(), out Phone))
        //{
        //    Console.WriteLine("Please input proper value for phone... :");
        //}
        //newstudent.Phone = Phone;

        

    }
}
