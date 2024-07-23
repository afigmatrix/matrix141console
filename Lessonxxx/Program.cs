using System;

namespace Lessonxxx
{
    internal class Program
    {
        //Task Enum
        #region
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            today = today.AddDays(2);

            WeekDay weekDay = (WeekDay)today.DayOfWeek;

            Console.WriteLine(NoweekDay(today) + "-ci gun");
            Console.WriteLine($"Week name: {weekDay}");
        }
        static int NoweekDay(DateTime today)
        {
            return (int)today.DayOfWeek;
        }

        public enum WeekDay
        {
            Bazarertesi = 1,
            CersenbeAxsami,
            Cersenbe,
            CumeAxsami,
            Cume,
            Senbe,
            Bazar
        }
        #endregion

        //Task Interface
        #region
        //static void Main(string[] args)
        //{
        //    Car icar = new Car();
        //    icar.moveing();
        //    icar.driver();
        //    icar.TheCarHas4doors();
        //    icar.TheCarHas4Wheels();
        //    Console.WriteLine();

        //    Bicyle bicyle = new Bicyle();
        //    bicyle.moveing();
        //    bicyle.driver();
        //    bicyle.theBicyleHas2wheels();
        //    bicyle.theBikeHasABell();
        //    Console.WriteLine();

        //    Boat boat = new Boat();
        //    boat.moveing();
        //    boat.driver();
        //    boat.TheBoatFloatsInTheWater();
        //    boat.TheBoatBecomesSmall();
        //    Console.WriteLine();
        //}

        //public interface IVehicle
        //{
        //    void moveing();
        //    void driver();
        //}

        //public interface Icar
        //{
        //    void moveing();
        //    void driver();
        //    void TheCarHas4doors();
        //    void TheCarHas4Wheels();
        //}
        //public class Car : Icar
        //{
        //    public void driver()
        //    {
        //        Console.WriteLine("The car is driven by a driver");
        //    }

        //    public void moveing()
        //    {
        //        Console.WriteLine("The car is moving");
        //    }

        //    public void TheCarHas4doors()
        //    {
        //        Console.WriteLine("The car has 4 doors");
        //    }

        //    public void TheCarHas4Wheels()
        //    {
        //        Console.WriteLine("The car has 4 wheels");
        //    }
        //}

        //public interface IBicyle
        //{
        //    void moveing();
        //    void driver();

        //    void theBicyleHas2wheels();
        //    void theBikeHasABell();

        //}
        //public class Bicyle : IBicyle
        //{
        //    public void driver()
        //    {
        //        Console.WriteLine("The car is driven by a driver");
        //    }

        //    public void moveing()
        //    {
        //        Console.WriteLine("The bicyle is moving");
        //    }

        //    public void theBicyleHas2wheels()
        //    {
        //        Console.WriteLine("The bicyle has 2 wheels");
        //    }

        //    public void theBikeHasABell()
        //    {
        //        Console.WriteLine("The bike has a bell");
        //    }
        //}

        //public interface IBoat
        //{
        //    void moveing();
        //    void driver();
        //    void TheBoatFloatsInTheWater();
        //    void TheBoatBecomesSmall();

        //}

        //public class Boat : IBoat
        //{
        //    public void driver()
        //    {
        //        Console.WriteLine("The boat is driven by a driver");
        //    }

        //    public void moveing()
        //    {
        //        Console.WriteLine("The boat is moving");
        //    }

        //    public void TheBoatBecomesSmall()
        //    {
        //        Console.WriteLine("The boat Becomes Small");
        //    }

        //    public void TheBoatFloatsInTheWater()
        //    {
        //        Console.WriteLine("The boat floats in the water");
        //    }
        //}
        #endregion
    }
}
