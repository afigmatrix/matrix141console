using System;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Lessonxxx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Thread

            //Thread kassa1 = new Thread(Method1);
            //Thread kassa2 = new Thread(Method2);
            //kassa1.Start();
            //kassa2.Start();
            //Method1();
            //Method2();
            //Method3();
            #endregion
            #region Task
            // Console.WriteLine("Start-" + Thread.CurrentThread.ManagedThreadId);
            //Method1();
            //Method2();
            //Method3();
            //Task task1 = AsyncMethod1();
            //Task task2 = AsyncMethod2();
            //Task task3 = AsyncMethod3();
            //await Task.WhenAll(task1, task2, task3);
            //  Console.WriteLine("End-" + Thread.CurrentThread.ManagedThreadId);
            #endregion

            //int result =await GetAge(1994);
            //Console.WriteLine(result);
            Singletone singletone = new Singletone();
            for (int i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    singletone.getInstance();
                }).Start();
            }
            Thread.Sleep(1000);
        }

        #region SyncMethod
        static void Method1()
        {
            Console.WriteLine("Method 1 start");
            Thread.Sleep(3000);
            Console.WriteLine("Method 1 end");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2 start");
            Thread.Sleep(3000);
            Console.WriteLine("Method 2 end");

        }
        static void Method3()
        {
            Console.WriteLine("Method 3 start");
            Thread.Sleep(3000);
            Console.WriteLine("Method 3 end");
        }
        static void Method4()
        {
            Console.WriteLine("Method 4 start");
            Console.WriteLine("Method 4 end");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        }
        #endregion
        #region AsyncMethod
        static async Task AsyncMethod1()
        {
            Console.WriteLine("AsyncMethod1 Start");
            await Task.Delay(3000);
            Console.WriteLine("AsyncMethod1 End");
        }
        static async Task AsyncMethod2()
        {
            Console.WriteLine("AsyncMethod2 Start");
            await Task.Delay(10000);
            Console.WriteLine("AsyncMethod2 End");
        }
        static async Task AsyncMethod3()
        {
            Console.WriteLine("AsyncMethod3 Start");
            await Task.Delay(1000);
            Console.WriteLine("AsyncMethod3 End");
        }
        static async Task<int> GetAge(int year)
        {
            int res = DateTime.Now.Year - year;







            return await Task.FromResult(res);
        }
        #endregion

    }


    public class Singletone
    {

        private object _lock = new object();
        private static Singletone _instance { get; set; } = null;

        public Singletone getInstance()
        {

            //Monitor,Background-Foreground thread
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singletone();
                    Console.WriteLine("New instance created");
                }
                else
                {
                    Console.WriteLine("Exist instance return");
                }
            }
            return _instance;
        }
    }
}
