using Lessonxxx.User.StringExtension;
using System;
using System.Threading;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            
            Console.WriteLine(thread1.ManagedThreadId);
            Console.WriteLine(thread2.ManagedThreadId);

            #region GC
            //Student student = new Student("Matrix");

            //for (int i = 0; i < 20; i++)
            //{
            //    student = new Student(i.ToString());
            //}

            //Thread.Sleep(3000);
            //Console.WriteLine("GC start");

            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            #endregion
        }

        static void Method1()
        {
            for (int i = 0; i < 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Method2()
        {
            for (int i = 2000; i < 4000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
