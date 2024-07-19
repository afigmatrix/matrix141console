using System;
using System.Runtime.CompilerServices;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Car car = new Car();
            car.DordTekerleHereket();
            car.Start();
            car.Stop();
            car.Drive();

            Boat boat = new Boat();
            boat.Drive();
            boat.Start();
            boat.Stop();
            boat.Drive();
            boat.SudaHereket();

            Bicycle bayk = new Bicycle();
            bayk.Drive();
            bayk.PedallaHereket();
            bayk.Stop();

            DateTime buGun = DateTime.Now;
            Console.WriteLine(GetWeekDAy((WeekDay)buGun.DayOfWeek));

        }
        public static int GetWeekDAy(WeekDay day)
        {

            return (int)day;
        }
    }
    public enum WeekDay
    {
        BazarErtesi = 1,
        CersenbeAxsami,
        Cersenbe,
        CumeAxsami,
        Cume,
        Senbe,
        Bazar
    }
    public interface IVehicle
    {
        void Drive();
        void Start();
        void Stop();
    }

    public interface ICar
    {
        public void DordTekerleHereket();
    }
    public interface IBicycle
    {
        public void PedallaHereket();
    }

    public interface IBoat
    {
        public void SudaHereket();
    }

    public class Car : IVehicle, ICar
    {
        public void DordTekerleHereket()
        {
            Console.WriteLine("Avtomobil 4 teker uzerinde hereket edir");
        }

        public void Drive()
        {
            Console.WriteLine("Avtomobil muherrik vasitesile calisir");
        }

        public void Start()
        {
            Console.WriteLine("Avtomobil ishe salindi");
        }

        public void Stop()
        {
            Console.WriteLine("Muherrik sonduruldu");
        }
    }
        public class Bicycle : IVehicle, IBicycle
        {
            public void Drive()
            {

            }

            public void Gas()
            {

            }

            public void PedallaHereket()
            {
                Console.WriteLine("Velosiped pedalla herekete baslayir");
            }

            public void Start()
            {

            }

            public void Stop()
            {
                Console.WriteLine("Velosiped el tormuzu ile dayandi");
            }

        }
    
    public class Boat : IVehicle, IBoat
    {
        public void Drive()
        {
            Console.WriteLine("Gemiler kapitanlar terefinden idare olunur");
        }

        public void Start()
        {
            Console.WriteLine("Gemi muherik vasiteile calisir");
        }

        public void Stop()
        {
            Console.WriteLine("Muherrik vasitesile dayanir");
        }

        public void SudaHereket()
        {
            Console.WriteLine("Suda hereket edir");
        }
    }
}
