using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.Run();
            rabbit.Eat();

            Dog dog = new Dog();
            dog.Run();
            dog.Eat();

            Cat cat = new Cat();
            cat.Run();
            cat.Eat();
        }

        public class Animal
        {
            public virtual void Run()
            {
                Console.WriteLine();
            }
            public virtual void Eat()
            {
                Console.WriteLine();
            }
        }
        public class Rabbit : Animal
        {
            public void Run()
            {
                Console.WriteLine("Rabbit runs");
            }
            public void Eat()
            {
                Console.WriteLine("Rabbit eats");
            }

        }
        public class Dog : Animal
        {
            public void Run()
            {
                Console.WriteLine("Dog runs");
            }
            public void Eat()
            {
                Console.WriteLine("Dog eats");
            }
        }
        public class Cat : Animal
        {
            public void Run()
            {
                Console.WriteLine("Cat runs");
            }
            public void Eat()
            {
                Console.WriteLine("Cat eats");
            }
        }

    }
}

