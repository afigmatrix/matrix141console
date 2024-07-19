using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetWeekDay(week.Thursday));            
        }
        #region Task1
        //static int GetWeekDay(week day)
        //{
        //    return (int)day;
        //}
        //public enum week
        //{
        //    Friday =5,
        //    Saturday,
        //    Sunday,
        //    Monday=1,
        //    Tuesday,
        //    Wednesday,
        //    Thursday
        //}
        #endregion
        public interface IVehicle
        {
            void Start();
            void Stop();
            void Drive();
        }
        public interface ICar
        {
            public int NumberofDoors();
        }
        public class Car : IVehicle, ICar
        {
            public void Drive()
            {
                Console.WriteLine("Car is driving");
            }

            public void Start()
            {
                Console.WriteLine("Car can start");
            }

            public void Stop()
            {
                Console.WriteLine("Car can stop");
            }
            public int NumberofDoors()
            {
                return 4;
            }

        }
        public interface IBike
        {
            bool FixedGear();
        }
        public class Bike : IVehicle, IBike
        {
            public void Drive()
            {
                Console.WriteLine("Bike is driving");
            }

            public void Start()
            {
                Console.WriteLine("Bike can start");
            }

            public void Stop()
            {
                Console.WriteLine("Bike can stop");
            }
            public bool FixedGear()
            {
                return true;
            }
        }
        public interface IBoat
        {
            void TypeofBoat();
        }
        public class Boat : IVehicle, IBoat
        {
            public void Drive()
            {
                Console.WriteLine("Boat is driving");
            }

            public void Start()
            {
                Console.WriteLine("Boat can start");
            }

            public void Stop()
            {
                Console.WriteLine("Boat can stop");
            }
            public void TypeofBoat()
            {
                Console.WriteLine("Bowriders");
            }
        }
    }
}
