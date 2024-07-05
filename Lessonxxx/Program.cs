using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird eagle = new Bird();
            eagle.weight = 35;
            eagle.height = 53;
            eagle.eyeColor = "brown";
            eagle.isWield = false;
            eagle.AbiltyToFly();

            Lion lion = new Lion();
            lion.weight = 600;
            lion.height = 160;
            lion.eyeColor = "blue";
            lion.isWield = false;
            lion.Jump();

            BMW bmw = new BMW("Alphina");
            bmw.isSport = true;
            bmw.isModified = true;
            bmw.color = "black";
            bmw.doorCount = 2;
            bmw.Start();
            bmw.Stop();


        }
        public class Animal
        {
            public int weight;
            public int height;
            public string eyeColor;
            public bool isWield;

            public void Run()
            {
            
            }
        }
        public class Bird : Animal
        {
            public void AbiltyToFly()
            {

            }
        }
        public class Lion : Animal
        {
            public void Jump()
            {

            }
        }
        public class Car
        {
            public bool isSport;
            public string color;
            public int doorCount;

            public void Start()
            {

            }
            public void Stop()
            {

            }
        }
        public class BMW : Car
        {
            public bool isModified;
            public string ModificationName;

            public BMW(string modificationName)
            {
                ModificationName = modificationName;
            }
        }
    }
}
