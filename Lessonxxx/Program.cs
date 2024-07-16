using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rb = new Rabbit();
            rb.Eat();
            rb.Run();

            Dog dog = new Dog();
            dog.Run();
            dog.Eat();

            Cat cat = new Cat();
            cat.Run();
            cat.Eat();

            Mercedes ml = new Mercedes();
            ml.FlashOptimizer();

            BMW bmw = new BMW();
            bmw.FlashOptimizer();


        }
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
            Console.WriteLine("The rabbit runs fast");
        }
        public override void Eat()
        {
            Console.WriteLine("Rabbit eats  carrots");
        }
    }
    public class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("The dog runs fast");
        }
        public override void Eat()
        {
            Console.WriteLine("A dog eats a bone ");
        }
    }
    public class Cat : Animal
    {
        public override void Run()
        {
            Console.WriteLine("The cat runs fast");
        }
        public override void Eat()
        {
            Console.WriteLine("A cat eat a fish");
        }
    }
    
    public abstract class Car
    {
        public int doorCount { get; set; }
        public string colorName { get; set; }
        public abstract void Gas();
        public abstract void Break();

        public virtual void FlashOptimizer()
        {
            Console.WriteLine("Optimallashdirici ishe salindi.");
        }

    }
    public class BMW : Car
    {
        public override void Gas()
        {
            Console.WriteLine("Avtomobil ishe salindi");
        }
        public override void Break()
        {
            Console.WriteLine("Avtomobil dayandi");
        }
        public override void FlashOptimizer()
        {
            Console.WriteLine("BMW flash ishe salindi");
        }

    }
    public class Mercedes : Car
    {
        public override void Gas()
        {
            Console.WriteLine("Qaz verende qara tustu cixir");
        }
        public override void Break()
        {
            Console.WriteLine("Nakladkalar cuyulduyur");
        }
        public override void FlashOptimizer()
        {
            base.FlashOptimizer();
        }
    }
}
