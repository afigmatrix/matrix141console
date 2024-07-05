using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            animal animal = new animal();
            animal.height = 100;
            animal.weight = 12;
            animal.isWild = true;
            animal.eyEcolor = "black";
            animal.run();
            Console.WriteLine();

            bird bird = new bird();
            bird.height = 16;
            bird.weight = 17;
            bird.isWild = true;
            bird.eyEcolor = "blue";
            bird.ucmaq = true;
            bird.AbilityToFly();

            Console.WriteLine();

            lion lion = new lion();
            lion.height = 16;
            lion.weight = 18;
            lion.isWild = true;
            lion.eyEcolor = "brown";
            lion.king = true;
            lion.jump();

            Console.WriteLine();


        }
        public class animal
        {

            public int weight;
            public int height;
            public string eyEcolor;
            public bool isWild;
            public void run()
            {
                Console.WriteLine(" qacmaq");
            }
        }


        public class bird : animal

        {
            public string eyEcolor;
            public bool isWild;
            public int weight;
            public int height;
            public bool ucmaq;

            public void AbilityToFly()
            {
                Console.WriteLine();
            }

        }

        public class lion : animal
        {


            public int weight;
            public int height;
            public string eyEcolor;
            public bool isWild;
            public bool king;

            public void jump()
            {
                Console.WriteLine();
            }
            #endregion
            #region
            Car car = new Car();
            
        }
        public class Car
        {
            public bool İsSport;
            public string Color;
            public int DoorCount;

            public void start()
            {

            }
            public void stop()
            {

            }
        }
        public class bmw : Car
        {
            bool isModified;
            string ModificationName;
            public void moid(string ModificationName)
            {
                ModificationName = ModificationName;
            }
#endregion




        }
    }
}
