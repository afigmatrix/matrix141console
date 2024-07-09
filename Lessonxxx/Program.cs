using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st1 = new Student();
            Student st2 = new Student();

            Console.WriteLine(Student.Count);
            //Human human = new Human();

            //int age = 30; //stack
            //object objAge = age; //boxing - heap

            //object count = 9; // bool,int,string,array

            //int intCount = (int)count; //unboxing


            //object[] objArray = new object[5];
            //objArray[0] = "Matrix";
            //objArray[1] = true;
            //objArray[2] = 4;
            //objArray[3] = 3;
            //objArray[4] = 'A';
            ////as-is
            //int totalCount = 0;

            //foreach (var item in objArray)
            //{
            //    if (item is int intValue)
            //    {
            //        totalCount += intValue;
            //    }
            //}

            //Nullable<int> myInt = 7;

            //myInt = null;

            //Student omer = new Student();
            //omer.Name = "Ferid";
            //object objStudent = omer;
            //Student stOmer = objStudent as Student;
            //Human hm = objStudent as Human;
            //Console.WriteLine(objStudent is Student);


            //int numver = 65; // 0x001-65
            //Console.WriteLine(numver);
            //ChangeNumver(ref numver); //0x001-90
            //Console.WriteLine(numver);

        }

        public static void ChangeNumver(ref int numver)
        {
            numver = 90;
        }
    }
    public class Human
    {
        protected int Id { get; private set; }
        protected string _prvStr;
        public Human()
        {
            Id = 3;
        }
    }

    public class Student : Human
    {
        public static int Count { get; set; }
        public int NSCount { get; set; }
        static Student()
        {
            Console.WriteLine("Static constructor start");
            //50 line code
            Console.WriteLine("Static constructor end");
        }
        public Student()
        {
            Count++;
            NSCount++;
            Console.WriteLine("Non-static constructor start");
            //50 line code
            Console.WriteLine("Non-static constructor end");
        }
        public string Name { get; set; }
    }
}
