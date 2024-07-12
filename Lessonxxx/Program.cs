using System;
using System.Security.Cryptography.X509Certificates;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Boxing-Unboxing

            // 1) Boxing
            int n = 15;
            object obj = n;
            // 2) Boxing
            bool b = true;
            object ob = b;
            // 3) Boxing
            float f = 1.9f;
            object o = f;
            // 4) Unboxing
            string str = "Name";
            object c = str;
            int a = (int)c;
            // 5) Unboxing
            object d = 0;
            bool e = (bool)d;
            #endregion


            #region Object Array

            object[] objc = new object[] { 1, 2, "a", "b", 5, "cd", 7, "vm", 9, "z" };
            int[] ints = new int[10];
            string[] strs = new string[10];
            int IndexInt = 0;
            int IndexStr = 0;

            foreach (var item in objc)
            {
                if (item is int intNum)
                {
                    ints[IndexInt] = (int)item;
                    IndexInt++;
                }
            }



            foreach (var item in objc)
            {
                if (item is string strWord)
                {
                    strs[IndexStr] = (string)item;
                    IndexStr++;
                }
            }

            Console.WriteLine("Integers:");

            for (int i = 0; i < IndexInt; i++)
            {
                Console.WriteLine(ints[i]);
            }

            Console.WriteLine("Strings:");

            for (int i = 0; i < IndexStr; i++)
            {
                Console.WriteLine(strs[i]);
            }

            #endregion


            #region Result ref

            int Result = 0;

            Calculator(5, 7, ref Result);

            Console.WriteLine($"Total: {Result}");

            static int Calculator(int num1, int num2, ref int Total)
            {
                Total = num1 + num2;

                return Total;
            }
            #endregion
            #region Instance sayi

            Car car = new Car();
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine(Car.MyCarNum1);

        }

        public class Car
        {
            public static int MyCarNum1 { get; set; }
            public int MyCarNum2 { get; set; }

            public Car()
            {
                MyCarNum1++;
                MyCarNum2++;
            }
        }
        #endregion


    }
}
