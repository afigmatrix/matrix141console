using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task

            Rabbit rabbit = new Rabbit();
            rabbit.Run();
            rabbit.Eat();

            Dog dog = new Dog();
            dog.Run();
            dog.Eat();

            Cat cat = new Cat();
            cat.Run();
            cat.Eat();

            Car mercedes = new Mercedes (4,"White");
            mercedes.Gas();
            mercedes.Break();
            mercedes.FlashOptimizer();

            Car bmw = new BMW (2,"Black");
            bmw.Gas();
            bmw.Break();
            bmw.FlashOptimizer();

        }

        public abstract class Animal
        {
            public abstract void Run();
            public abstract void Eat();
        }
        public class Rabbit : Animal
        {
            public override void Run()
            {
                Console.WriteLine("Rabbit runs");
            }
            public override void Eat()
            {
                Console.WriteLine("Rabbit eats");
            }

        }
        public class Dog : Animal
        {
            public override void Run()
            {
                Console.WriteLine("Dog runs");
            }
            public override void Eat()
            {
                Console.WriteLine("Dog eats");
            }
        }
        public class Cat : Animal
        {
            public override void Run()
            {
                Console.WriteLine("Cat runs");
            }
            public override void Eat()
            {
                Console.WriteLine("Cat eats");
            }
        }
       

        }

    public class Car
    {
        public int DoorCount { get; set; }
        public string ColorName { get; set; }
        public virtual void Gas()
        {
            Console.WriteLine("Normal suretlenen");
        }
        public virtual void Break()
        {
            Console.WriteLine("Sade tormoz");
        }

        public virtual void FlashOptimizer()
        {
            Console.WriteLine("Flash Optimizier");
        }

    }
    public class Mercedes : Car
    {
        public Mercedes(int doorCount, string colorName)
        {
            DoorCount = doorCount;
            ColorName = colorName;
        }
        public override void Gas()
        {
            Console.WriteLine("Mercedes Specific gas");
        }
        public override void Break()
        {
            Console.WriteLine("ABS brake");
        }

        public override void FlashOptimizer()
        {
            base.FlashOptimizer();
        }
    }
    public class BMW : Car
    {
        public BMW(int  doorCount, string colorName)
        {
            DoorCount=doorCount;
            ColorName = colorName;
        }
        public override void Gas()
        {
            Console.WriteLine("Sport gas");
        }
        public override void Break()
        {
            Console.WriteLine("ABS sfecific brake");
        }
        public override void FlashOptimizer()
        {
            Console.WriteLine("BMW flash optimizer");
            
        }
        #endregion



    }
}


