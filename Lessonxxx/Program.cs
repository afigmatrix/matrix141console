using System;

namespace Lessonxxx
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //T-1
        //    Console.WriteLine("Enter the string value");
        //    string Holding = Console.ReadLine();
        //    Console.WriteLine(St(Holding));

        //}

        //static bool St(string Holding)
        //{
        //    if (Holding.StartsWith ("A") || Holding.StartsWith ("B") || Holding.StartsWith("C"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        //T-2
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value greater than 10 in length");
            string gala = Console.ReadLine();
            Test(gala);
        }

        static void Test(string gala)
        {
            while(gala.Length < 10)
            {
                Console.WriteLine("Enter a valu greater than in length");
                gala = Console.ReadLine();
            }

            Console.WriteLine("You have entered the correct value: " + gala);
        }
    }
}
