using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Lessonxxx
{
    internal class Program
    {
        //Task1
        //Geriyə string qaytaran GetParameter(string name) adında asenkron  bir metod yaradın.
        //Bu metod aldığı parameterin ozunu ele asenkron formada geri qaytarsin
        #region
        //static async Task Main(string[] args)
        //{

        //    var result = await GetParameterAsync("Gala");
        //    Console.WriteLine(result);
        //}
        //static async Task<string> GetParameterAsync(string name)
        //{

        //    return await Task.FromResult(name);
        //}
        #endregion

        //Task2
        //num1,num2 parameterlerini alan metod yazın və geriyə bu iki rəqəmin cəmini qaytarsın

        #region
        //static async Task Main(string[] args)
        //{
        //    var result = await Method(5, 9);
        //    Console.WriteLine(result);
        //}

        //static async Task<int> Method(int num1,int num2)
        //{
        //    var result = num1 + num2;
        //    return await Task.FromResult(result);
        //}
        #endregion

        //Task3
        //Enum yaradın içində həftənin günlərinin adlarını saxlasın.Bir metodunuz olsun və int date parameteri alsın.
        //Verilən parameterin Enumda string qarşılığını asenkron geri qaytarin

        #region

        //static async Task Main(string[] args)
        //{
        //    var result = await Time(5);
        //    Console.WriteLine(result);
        //}

        //public enum Weekday
        //{
        //    Bazarertesi = 1,
        //    CersenbeAxsami,
        //    Cersenbe,
        //    CumeAxsami,
        //    Cume,
        //    Senbe,
        //    Bazar
        //}

        //static async Task<String> Time(int data)
        //{
        //    var result = Enum.GetName(typeof(Weekday), data);
        //    return await Task.FromResult(result);
        //}
        #endregion

        //Task4

        // Bir class dan əgər 1 instance alınıbsa yeni instance yaratmasın.Əgər alınmayıbsa yaradıb qaytarsın.

        #region
        //static void Main(string[] args)
        //{
        //    SinglTone singlTone = new SinglTone();
        //    singlTone.getInstance();
        //    singlTone.getInstance();
        //    singlTone.getInstance();
        //    singlTone.getInstance();
        //}

        //public class SinglTone
        //{
        //    private static SinglTone _instance { get; set; } = null;

        //    public SinglTone getInstance()
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new SinglTone();
        //            Console.WriteLine("Yeni nümune yaradıldı ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Movcud nume qaytarilmasi");
        //        }
        //        return _instance;
        //    }

        //}
        #endregion
    }
}
