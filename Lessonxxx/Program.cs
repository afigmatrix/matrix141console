using System;

namespace Lessonxxx
{
    internal class Program
    {
        //Task1
        #region
        //static void Main(string[] args)
        //{
        //   Animal animal = new Animal();
        //    animal.Weight = 7;
        //    animal.Height = 10;
        //    animal.EyeColor = "Black";
        //    Console.WriteLine($"yas: {animal.Weight}\nCeki: {animal.Height}\nGoz Rengi: {animal.EyeColor}");
        //}

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
        //    public void AbilityToFly()
        //    {

        //    }

        //}

        //public class Lion : Animal
        //{
        //    public void Jump()
        //    {

        //    }
        //}
        #endregion

        //Task2
        #region
        static void Main(string[] args)
        {
            Bmw b = new Bmw("530i");
            b.Brand = "BMW";
            b.Color = "Ag";
            b.DoorCount = 4;
            b.graduationYear = 2017;
            b.BanType = "Sedan";
            b.Engine = "2.0 l/249 a.g./Benzin";
            b.Distance = "150.000 km";
            b.GearBox = "Avtomat";

            Console.WriteLine($"Marka: {b.Brand}\nModel: {b.ModificationName}\nReng: {b.Color}\nQapi sayisi: {b.DoorCount}\n" +
                $"Buraxilis ili: {b.graduationYear}\nBan Novu: {b.BanType}\nMuherrik: {b.Engine}\n" +
                $"Yurus: {b.Distance}\nSuretler Qutusu: {b.GearBox}");
        }

        public class Car
        {
            public int DoorCount;
            public string Color;
            public string Brand;
            public int graduationYear;
            public string BanType;
            public string Engine;
            public string Distance;
            public string GearBox;

            public bool IsSport;


            public void Start()
            {

            }

            public void Stop()
            {

            }


        }

        public class Bmw : Car
        {
            public bool isModified;
            public string ModificationName;

            public Bmw(string modificationName)
            {
                ModificationName = modificationName;
            }
        }
        #endregion

    }
}
