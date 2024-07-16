using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tapsiriq1
            Rabbit rabbit = new Rabbit();
            Dog dog = new Dog();
            Cat cat = new Cat();
            characteristic(dog);
            #endregion

            #region tapsiriq2
            BMW bmw = new BMW();
            Audi audi = new Audi();
            CharacteristicsCar(bmw);
            #endregion
        }
        #region tapsiriq1
        public static void characteristic(Animal animal)
        {
            animal.Eat();
            animal.Run();
        }
        #endregion
        #region tapsiriq2
        public static void CharacteristicsCar(Car car)
        {
            car.Gas();
            car.Break();
            car.FlashOptimizer();
        }
        #endregion
    }
    #region tapsiriq1
    public abstract class Animal
    {
        public abstract void Run();
        public abstract void Eat();

    }
    public class Rabbit : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Rabbit is running");
        }
        public override void Eat()
        {
            Console.WriteLine("Rabbit is eating");
        }
    }
    public class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Dog is running");
        }
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
    public class Cat : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Cat is running");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
    }
    #endregion
    #region tapsiriq2
    public abstract class Car
    {
        public int DoorCount { get; set; }
        public string ColorName { get; set; }
        public abstract void Gas();
        public abstract void Break();
        public virtual void FlashOptimizer()
        {
            Console.WriteLine("is working");
        }
    }
    public class BMW : Car
    {
        public override void Gas()
        {
            Console.WriteLine("BMW is accelerating.");
        }
        public override void Break()
        {
            Console.WriteLine("BMW is braking.");
        }
        public override void FlashOptimizer()
        {
            Console.WriteLine("BMW's customized FlashOptimizer method.");
        }
    }
    public class Audi : Car
    {
        public override void Gas()
        {
            Console.WriteLine("Audi is accelerating.");
        }

        public override void Break()
        {
            Console.WriteLine("Audi is braking.");
        }
        public override void FlashOptimizer()
        {
            Console.WriteLine("Audi's customized FlashOptimizer method.");
        }
    }
    #endregion
}
