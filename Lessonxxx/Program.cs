using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum

            DateTime today = DateTime.Now;
            DayOfWeek dayOfWeek = today.DayOfWeek;

            Console.WriteLine(WeekDayName((Week)dayOfWeek));


            Car car = new Car();
            car.Dayanir();
            car.HereketEdir();
            car.TehlukesizlikKemeri();

            Bicycle bicycle = new Bicycle();
            bicycle.HereketEdir();
            bicycle.Dayanir();
            bicycle.VelosipedSebeti();

            Boat boat = new Boat();
            boat.HereketEdir();
            boat.Dayanir();
            boat.Lovber();

            IBoat boat1 = new Boat();
            boat1.Lovber();


        }
        static string WeekDayName(Week day)
        {
            return day.ToString();
        }
        public enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
        #endregion





        #region interface

        public interface IVehicle
    {
        void HereketEdir();
        void Dayanir();
    }
    public interface ICar
    {
        void TehlukesizlikKemeri();
    }
    public interface IBicycle
    {
        void VelosipedSebeti();
    }
    public interface IBoat
    {
        void Lovber();
    }

    public class Car : IVehicle, ICar
    {
        public void HereketEdir()
        {
            Console.WriteLine("Avtomobil hereket edir");
        }
        public void Dayanir()
        {
            Console.WriteLine("Avtomobil dayanir");
        }
        public void TehlukesizlikKemeri()
        {
            Console.WriteLine("Tehlukesizlik kemerini taxin");

        }
    }

    public class Bicycle : IVehicle, IBicycle
    {
        public void HereketEdir()
        {
            Console.WriteLine("Velosiped hereket edir");
        }

        public void Dayanir()
        {
            Console.WriteLine("Velosiped dayanir");
        }
        public void VelosipedSebeti()
        {
            Console.WriteLine("Esylari sebete qoyun");
        }
    }
    public class Boat : IVehicle, IBoat
    {
        public void HereketEdir()
        {
            Console.WriteLine("Qayiq hereket edir");
        }
        public void Dayanir()
        {
            Console.WriteLine("Qayiq dayanir");
        }
        public void Lovber()
        {
            Console.WriteLine("Qayiq lovber salir");
        }
    }
        #endregion

    }
}
