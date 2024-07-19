using System;
using System.Security.Cryptography;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir enum yaradın və həftənin günlərini təmsil edəcək.Bu enum-u istifadə edərək həftənin hansı gününün
            //olduğuna ekrana verən bir metod yaradın.Günü hazırki gündən götürəcəksiz

            #region task1
            //DateTime day = DateTime.Now;
            //Console.WriteLine(GetDayofWeek((Week)day.DayOfWeek));
            #endregion
            //Müxtəlif nəqliyyat vasitələrini təmsil edən IVehicle interfeysini yaradın və bu interfeysi tətbiq edən Car,
            //Bicycle, və Boat siniflərini yaradaraq hər bir sinifin ortaq xüsusiyyətlərini göstərən metodlar əlavə edin.
            //Sonra hər bir class a aid imterface lər yaradın və yalnız o classa məxsus xüsusiyyətləri öz interface də verib implememt edin
            #region task2
            Boat boat = new Boat();
            boat.Start();
            boat.Stop();
            boat.Drive();
            boat.MoveOnWater();
            Car car = new Car();
            car.Start();
            car.Stop();
            car.Drive();
            car.OpenWindows();
            car.DriveOnFourWheel();
            Bicycle bicycle = new Bicycle();
            bicycle.Start();
            bicycle.Stop();
            bicycle.Drive();
            bicycle.MoveOnTwoWheel();
            #endregion
        }
        static string GetDayofWeek(Week day)
        {
            return day.ToString();
        }
    }
    public enum Week
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    public interface IVehicle
    {
        void Drive();
        void Start();
        void Stop();
    }
    public interface ICar
    {
        void OpenWindows();
        void DriveOnFourWheel();
    }
    public interface IBoat
    {
        void MoveOnWater();
    }
    public interface IBicycle
    {
        void MoveOnTwoWheel();
    }
    public class Car : ICar, IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Masin insanlar terefinden idare olunur");
        }

        public void DriveOnFourWheel()
        {
            Console.WriteLine("Masin 4 teker uzerinde hereket edir");
        }

        public void OpenWindows()
        {
            Console.WriteLine("Masinin acilib-baglanan pencereleri var");
        }

        public void Start()
        {
            Console.WriteLine("Masin hereket etmeyi baslayir");
        }

        public void Stop()
        {
            Console.WriteLine("Masin hereketini dayandirir");
        }
    }
    public class Bicycle : IVehicle, IBicycle
    {
        public void Drive()
        {
            Console.WriteLine("Velosiped insanlar terefinden idare olunur");
        }

        public void MoveOnTwoWheel()
        {
            Console.WriteLine("Velosiped 2 teker uzerinde hereket edir");
        }

        public void Start()
        {
            Console.WriteLine("Velosiped hereket etmeyi baslayir");
        }

        public void Stop()
        {
            Console.WriteLine("Velosiped hereketini dayandirir");
        }
    }
    public class Boat : IBoat, IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Boat insanlar terefinden idare olunur");
        }

        public void MoveOnWater()
        {
            Console.WriteLine("Boat su uzerinde hereket edir");
        }

        public void Start()
        {
            Console.WriteLine("Boat hereket etmeyi baslayir");

        }

        public void Stop()
        {
            Console.WriteLine("Boat hereketini dayandirir");
        }
    }
}
