using System;
using System.Globalization;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //CustomInt age = new CustomInt();
            //age.Value = 18;
            //CustomBool isActive = new CustomBool();
            //isActive.Value = false;
            //ValueType valueType = age;
            //ValueType boolValueType = isActive;
            #endregion
            #region Enum
            //int bErtesi = 1;
            //int cAxsami = 2;
            //int cersembe = 3;
            ////...
            //int bazar = 7;
            //Console.WriteLine(GetWeekDayName((Week)3));
            #endregion
            #region const-readonly
            //Baby afiq = new Baby("Nazim");
            //afiq.arr[0] = 8;
            //afiq.arr[0] = 28;
            //Baby eli = new Baby("Huseyn");
            //Console.WriteLine(afiq.Ata_adi);
            #endregion
            #region Interface
            IBicag batman = new Batman();

            batman.Kes();

            #endregion
            //try-catch-exception
        }

        static string GetWeekDayName(Week day)
        {
            return day.ToString();
        }
        static BMW CreateBMW(string color = "White", int d_count = 4)
        {
            BMW newCare = new BMW();
            newCare.Color = color;
            newCare.DoorCount = d_count;
            return newCare;
        }

    }

    public class Batman : IBicag,YalinEl
    {
        public void Desici()
        {
            Console.WriteLine("Yumruqla doyusur");
        }

        public string Doyus(bool isHard)
        {
            Console.WriteLine("Yumruqla doyusur");
            return "Matrix";
        }

        public void Kes()
        {
            Console.WriteLine("Yarasa bicagi");
        }
    }

    public interface ISilah
    {
        int Ates();
    }

    public interface IBicag
    {
        void Desici();
        void Kes();
    }

    public interface YalinEl
    {
        string Doyus(bool isHard);
    }

    public class Baby
    {
        public Baby(string ata_adi)
        {
            Ata_adi = ata_adi;
        }
        public const string MILLIYET = "azerbaycanli"; //static
        public readonly string Ata_adi;
        public readonly int[] arr = new int[4];
    }
    public enum Week
    {
        BazarErtesi = 1,
        CersembeAxsami,
        Cersembe,
        CumeAxsami,
        Cume,
        Senbe,
        Bazar
    }
    public class BMW
    {
        public int DoorCount { get; set; }
        public string Color { get; set; }
    }
    public struct CustomInt
    {
        public int Value { get; set; }
    }
    public struct CustomBool
    {
        public bool Value { get; set; }
    }





}
