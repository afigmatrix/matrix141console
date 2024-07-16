using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Rabbit rabbit = new Rabbit();
            rabbit.Run();
            rabbit.Eat();
            Dog dog = new Dog();
            dog.Run();
            dog.Eat();
            Cat cat = new Cat();
            cat.Run();
            dog.Run();


        }
        public abstract class Animal
        {
            public abstract void Eat();
            public abstract void Run();
        }
        public class Rabbit : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("yemek");
            }
            public override void Run()
            {
                Console.WriteLine("qacmaq");
            }

        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("yemek");
            }
            public override void Run()
            {
                Console.WriteLine("qacmaq");
            }

        }
        public class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("yemek");
            }
            public override void Run()
            {
                Console.WriteLine("qacmaq");
            }
            #endregion
            #region
            BMW bmw = new BMW();



        }
        public abstract class Car
        {
            public abstract int QapıSayı { get; }
            public abstract string RəngAdı { get; }


            public abstract void Gas();
            public abstract void Break();


            public void FlashOptimizator()
            {
                Console.WriteLine("");
            }

        }
        public class BMW : Car
        {
            public override string RəngAdı => "qara";
            public override int QapıSayı => 2;

            public override void Gas()
            {
                Console.WriteLine(".");
            }

            public override void Break()
            {
                Console.WriteLine("");
            }
            #endregion


        }
    }
}
