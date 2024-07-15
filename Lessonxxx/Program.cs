using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new BMW();
            bmw.DoorCountColorName();
        }
        #region Task1
        //public abstract class Animal
        //{
        //    public abstract void Run();
        //   public abstract void Eat();
        //}
        //public class Rabbit : Animal
        //{
        //    public override void Run()
        //    {
        //        Console.WriteLine("Rabbit is runnig");
        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Rabbit is eating");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public override void Run()
        //    {
        //        Console.WriteLine("Dog is running");
        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Dog is eating");
        //    }
        //}
        //public class Cat : Animal
        //{
        //    public override void Run()
        //    {
        //        Console.WriteLine("Cat is running");
        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Cat is eating");
        //    }
        //}
        #endregion 
        public abstract class Car
        {
            public abstract void DoorCountColorName();
            public abstract void GasBreak();
            public virtual void FlashOptimizer()
            {
                Console.WriteLine("Led headlights");
            }
        }
        public class BMW : Car
        {
            public override void DoorCountColorName()
            {
                Console.WriteLine("Black BMW with 4 doors");
            }

            public override void GasBreak()
            {
               
            }
        }
        public class Mercedes : Car
        {
            public override void DoorCountColorName()
            {
                Console.WriteLine("White mercedes with 2 doors");

            }
            public override void GasBreak()
            {
                
            }
            public override void FlashOptimizer()
            {
                Console.WriteLine("Xenon headlights");
            }
        }
    }
}
