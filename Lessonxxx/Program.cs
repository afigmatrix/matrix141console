using System;
using System.Runtime.ConstrainedExecution;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartSystem();
            car.BreakSystem();
            car.SpeedSystem();
            car.AirSystem();
            Boat boat = new Boat();
            boat.StartSystem();
            boat.BreakSystem();
            boat.SpeedSystem();
            boat.RadarSystem();
            Bicycle bicycle = new Bicycle();
            bicycle.StartSystem();
            bicycle.BreakSystem();
            bicycle.SpeedSystem();
            bicycle.RingSystem();
        }
    }
    public interface IVehicle
    {
        void StartSystem();
        void BreakSystem();
        void SpeedSystem();
    }
    public interface ICar : IVehicle
    {
        void AirSystem();
    }
    public class Car : ICar
    {
        public void AirSystem()
        {
            Console.WriteLine("Air system of car is working");
        }
        public void BreakSystem()
        {
            Console.WriteLine("Break system of car is working");
        }
        public void SpeedSystem()
        {
            Console.WriteLine("Break system of car is working");
        }
        public void StartSystem()
        {
            Console.WriteLine("Start system of car is working");
        }
    }
    public interface IBoat : IVehicle
    {
        void RadarSystem();
    }
    public class Boat : IBoat
    {
        public void BreakSystem()
        {
            Console.WriteLine("Break system of boat is working");
        }
        public void RadarSystem()
        {
            Console.WriteLine("Radar system of boat is working");
        }
        public void SpeedSystem()
        {
            Console.WriteLine("Speed system of boat is working");
        }
        public void StartSystem()
        {
            Console.WriteLine("Start system of boat is working");
        }
    }
    public interface IBicycle : IVehicle
    {
        void RingSystem();
    }
    public class Bicycle : IBicycle
    {
        public void BreakSystem()
        {
            Console.WriteLine("Break system of Bicycle is working");
        }
        public void RingSystem()
        {
            Console.WriteLine("Ring system of Bicycle is working");
        }
        public void SpeedSystem()
        {
            Console.WriteLine("Speed system of Bicycle is working");
        }
        public void StartSystem()
        {
            Console.WriteLine("Start system of Bicycle is working");
        }
    }
}
