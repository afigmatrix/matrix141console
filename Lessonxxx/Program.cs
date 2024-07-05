using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Lessonxxx
{
    internal class Program
    {
        #region Task Animal
        static void Main(string[] args)
        {

            Bird bird = new Bird();

            bird.Weight = 20;
            bird.Height = 15;
            bird.EyeColor = "Brown";
            bird.isWild = false;
            bird.Name = "Sparrow";
            bird.fly = true;
            bird.Wing = true;           //Qanad
            bird.Beak = true;           //dimdik

            bird.AbilityToFly();
            

            Lion lion = new Lion();

            lion.Weight = 250;
            lion.Height = 120;
            lion.EyeColor = "Golden";
            lion.isWild = true;
            lion.Teeth = true;
            lion.Paw = true;             //Pence

            lion.Jump();

            BMW bmw = new BMW("X5 Limited");  
            
            bmw.İsSport = true;
            bmw.Color = "Black";
            bmw.DoorCount = 5;
            bmw.isModified = true;

            Console.WriteLine(bmw.ModificationName);

        }

        public class Animal
        {
            public int Weight;
            public int Height;
            public string EyeColor;
            public bool isWild;

            public void Run()
            {
                Console.WriteLine();
            }
        }

        public class Bird : Animal
        {
            public string Name;
            public bool fly;
            public bool Wing;
            public bool Beak;

            public void AbilityToFly()
            {
                Console.WriteLine("This animal can fly");
            }
        }

        public class Lion : Animal
        {
            public bool Teeth;
            public bool Paw;

            public void Jump()
            {
                Console.WriteLine("This animal can jump");
            }

        }

        #endregion


        #region Task Car

        public class Car
        {
            public bool İsSport;
            public string Color;
            public int DoorCount;

            public void Start()
            {
                Console.WriteLine();
            }
            public void Stop() 
            {
                Console.WriteLine();    
            }
        }

        public class BMW : Car
        {
           public bool isModified;
           public string ModificationName;

            public BMW(String modificationName)
            {
                ModificationName = modificationName;
            }

        }
        #endregion

    }
}
