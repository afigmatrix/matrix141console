using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Bird bird = new Bird();
            //    bird.Weight = 10;
            //    bird.Height = 2;
            //    bird.EyeColor = "brown";
            //    bird.isWild = true;
            //    Lion lion = new Lion();
            //    lion.Weight = 100;
            //    lion.Height = 2;
            //    lion.EyeColor = "black";
            //    lion.isWild = true;


            Car car = new Car();
            car.İsSport = true;
            car.Color = "black";
            car.DoorCount = 4;
            BMW bmw = new BMW("full");
            bmw.İsSport = false;
            bmw.Color = "red";
            bmw.DoorCount = 4; 
            bmw.isModified = true;

        }
        //public class Animal
        //{
        //    public int Weight;
        //    public int Height;
        //    public string EyeColor;
        //    public bool isWild;
        //    public void Run()
        //    {

        //    }
        //}
        //public class Bird : Animal
        //{
        //     public void AbilityToFly()
        //    {

        //    }
        //}
        //public class Lion : Animal
        //{
        //    public void Jump()
        //    {

        //    }
        //}
        public class Car
        {
            public bool İsSport;
            public string Color;
            public int DoorCount;
            static void Start()
            {

            }
            static void Stop()
            {

            }
        }
        public class BMW : Car
        {
            public bool isModified;
            public string ModificationName;
            public BMW(string mn)
            {
                ModificationName = mn;
            }
        }

    }
}
