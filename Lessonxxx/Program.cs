using System;

namespace Lessonxxx
{
    internal class Program
    {

        //Task1 Boxing
        #region

        //static void Main(string[] args)
        //{
        //    
        //    int num = 6;
        //    object objNum = num;
        //    num = 5;

        //    int i = 123;
        //    object objO = i;
        //    i = 456;

        //    int n = 45;
        //    object objN = n;
        //    n = 8;

        //    int t = 39;
        //    object objT = t;
        //    t = 9;

        //    int m = 7;
        //    object objM = m;
        //    m = 999;

        //    Console.WriteLine("The value-type value = {0}", num);
        //    Console.WriteLine("The value-type value = {0}", i);
        //    Console.WriteLine("The value-type value = {0}", n);
        //    Console.WriteLine("The value-type value = {0}", t);
        //    Console.WriteLine("The value-type value = {0}", m);

        //    Console.WriteLine("-----------------------------------");
        //    //Unboxing
        //    object count = 10;
        //    int ICount = (int)count;

        //    object number = true;
        //    bool bNumber = (bool)number;

        //    object print = "Matrix";
        //    string Sprint = (string)print;

        //    object scan = 35;
        //    int Iscan = (int)scan;

        //    object keys = "Metin";
        //    string Stkeys = (string)keys;

        //    Console.WriteLine("The value-type value = {0}", count);
        //    Console.WriteLine("The value-type value = {0}", bNumber);
        //    Console.WriteLine("The value-type value = {0}", Sprint);
        //    Console.WriteLine("The value-type value = {0}", Iscan);
        //    Console.WriteLine("The value-type value = {0}", Stkeys);

        #endregion

        //Task2 
        #region
        static void Main(string[] args)
        {
            Object[] objArr = new Object[10];
            objArr[0] = 11;
            objArr[1] = 2;
            objArr[2] = "Galatasaray";
            objArr[3] = 77;
            objArr[4] = "Academy";
            objArr[5] = 1;
            objArr[6] = 4.7;
            objArr[7] = "Matrix";
            objArr[8] = 5;
            objArr[9] = 10;

            int[] intArr = new int[objArr.Length];
            string[] StringArr = new string[objArr.Length];

            int intIndex = 0;
            int StringIndex = 0;

            foreach (object item in objArr)
            {
                if (item is int)
                {
                    intArr[intIndex] = (int)item;
                    intIndex++;
                }
                else if (item is string)
                {
                    StringArr[StringIndex] = item as string;
                    StringIndex++;
                }

            }

            Console.WriteLine("intArr");
            for (int i = 0; i < intIndex; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            Console.WriteLine("stringArr");
            for (int i = 0; i < StringIndex; i++)
            {
                Console.WriteLine(StringArr[i]);

            }

        }
        #endregion

        //Task3
        #region
        //static void Main(string[] args)
        //{
        //    int Result = 0;
        //    int num1 = 10;
        //    int num2 = 20;
        //    Calculate(num1, num2, ref Result);
        //    Console.WriteLine("Cavab: " + Result);
        //}
        //static void Calculate(int num1, int num2, ref int Result)
        //{
        //    Result = num1 + num2;
        //}
        #endregion

        //Task4
        #region
        //static void Main(string[] args)
        //{
        //    File file = new File();
        //    File fl1 = new File();
        //    File fl2 = new File();
        //    File fl3 = new File();
        //    Console.WriteLine("Say: " + File.MyCount);
        //}

        //public class File
        //{
        //    public static int MyCount { get; set; } //Mycount = 0;
        //    public File()
        //    {
        //        MyCount = MyCount + 1;
        //    }
        //}
        #endregion

    }
}
