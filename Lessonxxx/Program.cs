using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat();
            cat.Run();
            Dog dog = new Dog();
            dog.Eat();
            dog.Run();
            Rabbit rabbit = new Rabbit();
            rabbit.Eat();
            rabbit.Run();
            BMW bMW = new BMW();
            bMW.ColorName = "red";
            bMW.DoorCount = 4;
            bMW.Break();
            bMW.FlashOptimizer();
            bMW.Gas();
            Mercedes mercedes = new Mercedes();
            mercedes.ColorName = "blue";
            mercedes.DoorCount = 4;
            mercedes.Break();
            mercedes.FlashOptimizer();
            mercedes.Gas();
        }
    }
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Run();
    }
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat Eat");
        }
        public override void Run()
        {
            Console.WriteLine("Cat Run");
        }
    }
    public class Rabbit : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Rabbit Eat");
        }
        public override void Run()
        {
            Console.WriteLine("Rabbit Run");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Eat");
        }
        public override void Run()
        {
            Console.WriteLine("Dog Run");
        }
    }
    public abstract class Car
    {
        public int DoorCount { get; set; }
        public string ColorName { get; set; }
        public abstract void Gas();
        public abstract void Break();
        public virtual void FlashOptimizer()
        {
            Console.WriteLine("Total");
        }
    }
    public class BMW : Car
    {
        public override void Gas()
        {
            Console.WriteLine("For bmw gas");
        }
        public override void Break()
        {
            Console.WriteLine("For bmw break");
        }
    }
    public class Mercedes : Car
    {
        public override void Gas()
        {
            Console.WriteLine("For mercedes gas");
        }
        public override void Break()
        {
            Console.WriteLine("For mercedes break");
        }
        public override void FlashOptimizer()
        {
            Console.WriteLine("Mercedes flashoptimizer");
        }
    }
}
