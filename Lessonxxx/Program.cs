using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Task1

            // //  Geriyə string qaytaran GetParameter(string name) adında asenkron  bir metod yaradın.
            // //  Bu metod aldığı parameterin ozunu ele asenkron formada geri qaytarsin

            //    string result = await GetParametr("Matrix");

            //    Console.WriteLine(result);
            //}
            //public static async Task<string> GetParametr(string name)
            //{

            //    return await Task.FromResult(name);
            #endregion

            #region Task2


            // //   num1,num2 parameterlerini alan metod yazın və geriyə bu iki rəqəmin cəmini qaytarsın


            //    int result = await Calculator(7, 8);
            //    Console.WriteLine(result);

            //}
            //public static async Task<int> Calculator(int num1, int num2)
            //{
            //    int Sum = num1 + num2;
            //    return await Task.FromResult(Sum);
            #endregion

            #region Task3

            // //  Enum yaradın içində həftənin günlərinin adlarını saxlasın.
            // //  Bir metodunuz olsun və int date parameteri alsın.
            // //  Verilən parameterin Enumda string qarşılığını asenkron geri qaytarin



            //    DateTime dateTime = DateTime.Now;

            //    int date = (int)dateTime.DayOfWeek;
            //    string result = await Method(date);

            //    Console.WriteLine(result);
            //}
            //public enum WeekDays
            //{
            //    Monday = 1,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}
            //public static async Task<string> Method(int date)
            //{
            //    string WeekDayName = Enum.GetName(typeof(WeekDays), date);
            //    return await Task.FromResult(WeekDayName);

            #endregion


         


        }
    }
}
