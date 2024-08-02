using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lessonxxx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region task1
            //string result = await GetParameter("Salam");
            //Console.WriteLine(result);
            #endregion
            #region task2
            //int result = await Sum(3, 4);
            //Console.WriteLine(result);
            #endregion
            #region task3
            //string weekofday = await For_Enum(4);
            //Console.WriteLine(weekofday);
            #endregion
            #region task4
            SingleTone singleTone = new SingleTone();
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => 
                { singleTone.For_Instance(); 
                });
            }
            #endregion
        }
        #region task1
        static async Task<string> GetParameter(string name)
        {
            return await Task.FromResult(name);
        }
        #endregion
        #region task2
        static async Task<int> Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return await Task.FromResult(result);
        }
        #endregion
        #region task3
        public enum Week_day
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static async Task<string> For_Enum(int date)
        {
            return await Task.Run(() =>
            {
                if (Enum.IsDefined(typeof(Week_day), date))
                {
                    Week_day day = (Week_day)date;
                    return day.ToString();
                }
                else
                {
                    return "Proses yerine yetirilmedi";
                }
            });
        }
        #endregion 
    }
    #region task4
    public class SingleTone
    {
        private static SingleTone instance { get; set; } = null;
        private object _lock = new object();
        public SingleTone For_Instance() 
        { 
            lock (_lock)
            {
                if(instance == null)
                {
                    instance = new SingleTone();
                    Console.WriteLine("Yeni instance yaradildi.");
                }
                else
                {
                    Console.WriteLine("Yaradilan instance geri qaytarildi.");
                }
                return instance;
            }
        }
    }
    #endregion
}
