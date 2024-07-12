using System;
using System.ComponentModel.Design;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism
            //Polymorphism
            //Claculator calcIns = new Claculator(); Statik
            //calcIns.Calculate(5, 9);


            //XeyrsizOvlad elimemmedhuseyn = new XeyrsizOvlad(); 
            //elimemmedhuseyn.Davranis();

            //XeyrsizOvlad xo = new XeyrsizOvlad();
            //xo.Age = 18;
            //Console.WriteLine(xo);
            #endregion
            #region Abstraction

            Shape round = new Round();

            Shape square = new Square();

            CalculateShapeArea(round, 4, 9);
            CalculateShapeArea(square, 4, 9);
            #endregion
            // Women men = new Women("Turkay");
            Women createdWoman = CreateNewWoman("Turkay", 17);
            Console.WriteLine(createdWoman.Age);
        }

        static Women CreateNewWoman(string name, int age)
        {
            Women women = new Women(name);
            women.Age = age;
            return women;
        }


        static void CalculateShapeArea(Shape shape, int width, int height)
        {
            Console.WriteLine(shape.CalculateArea(width, height));
        }
    }

    public class Human
    {
        public Human(string name)
        {

        }
    }

    public class Women : Human
    {
        public int Age { get; set; }
        public Women(string name) : base(name)
        {

        }
    }
    public abstract class Shape
    {
        public abstract int CalculateArea(int width, int height);
    }

    public class Square : Shape
    {
        public override int CalculateArea(int width, int height)
        {
            return width + height / 2;
        }
    }

    public class Round : Shape
    {
        public override int CalculateArea(int width, int height)
        {
            return width + height;
        }
    }

    public class Claculator
    {

        public int Calculate(int num1, int num2 = 0)
        {
            return num1 + num2;
        }

        public int Calculate(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Calculate(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
    }

    public class Father   //Base-Super
    {

        public virtual void Davranis()
        {
            Console.WriteLine("Ata nesiheti");
        }
    }

    public class XeyrsizOvlad : Father  //Derived-Sub
    {
        public int Age { get; set; }
        public new void Davranis() //Dinamik
        {
            Console.WriteLine("Ozbildiyim");
        }
    }
}
