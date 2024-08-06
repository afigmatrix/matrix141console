using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Lessonxxx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string result = await GetParametr("Matrix");
            Console.WriteLine(result);

            int res = await AsyncTask(55, 45);
            Console.WriteLine(res);

            string cavab = await EnumStringGetirAsync(7);
            Console.WriteLine(cavab);

            SingleTon singleTon = new SingleTon();
            
            for (int i = 0; i < 10; i++)
            {
                singleTon.getInstance();
            }



        }
        // Geriyə string qaytaran GetParameter(string name) adında asenkron  bir metod yaradın.
        // Bu metod aldığı parameterin ozunu ele asenkron formada geri qaytarsin

        static async Task<string> GetParametr(string name)
        {
            return await Task.FromResult(name);
        }

        // num1,num2 parameterlerini alan metod yazın və geriyə bu iki rəqəmin cəmini qaytarsın
        static async Task<int> AsyncTask(int num1, int num2)
        {
            int res = num1 + num2;
            return await Task.FromResult(res);
        }
        // Enum yaradın içində həftənin günlərinin adlarını saxlasın.Bir metodunuz olsun və int date parameteri alsın.
        // Verilən parameterin Enumda string qarşılığını asenkron geri qaytarin.
        public static async Task<string> EnumStringGetirAsync(int gunIndex)
        {
            //return await Task.Run(() =>
            //{
            //    if (Enum.IsDefined(typeof(Gunler), gunIndex))
            //    {
            //        return ((Gunler)gunIndex).ToString();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlis sorgu");
            //        return null;
            //    }
            //});

            string res = Enum.GetName(typeof(Gunler), gunIndex);
            return await Task.FromResult(res);
        }

    }
    enum Gunler
    {
        BazarErtesi = 1,
        CersenbeAxsami,
        Cersenbe,
        CumeAxsami,
        Cume,
        Senbe,
        Bazar,
    }
    public class SingleTon
    {
      private object control = new object();
        private SingleTon _instance { get; set; } = null;
        
        public  SingleTon getInstance()
        {
            lock (control)
            {
                if (_instance == null)
                {
                    _instance = new SingleTon();
                    Console.WriteLine("Ilk instance yaradildi");
                }
                else
                {
                    Console.WriteLine("Instance yeniden yaradildi");
                }
            }
            return _instance;
        }
        


    }
}