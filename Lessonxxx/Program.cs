using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MyClass myClass = new MyClass();
            //MyClass myClass2 = new MyClass();
            //MyClass my = new MyClass();
            //Console.WriteLine($"Instance sayi:{MyClass.Count}");

            //int result = 0;
            //int _num1 = 0;
            //int _num2 = 0;
            //Calculator(_num1,_num2,ref result);
            //Console.WriteLine($"Netice:{result}");

            #region Boxing-Unboxing
            //int year = 1988;
            //object _year = year;
            //int newYear = (int)_year;
            //Console.WriteLine(newYear);

            //char value = 'A';
            //object objChar = value;
            //char _value = (char)objChar;
            //Console.WriteLine(value);

            //string name = "Test";
            //object objStr = name;
            //string str = (string)objStr;
            //Console.WriteLine(str);

            //bool test = true;
            //object objBool = test;
            //bool result = (bool)objBool;
            //Console.WriteLine(result);

            //double db = 12.5;
            //object objDouble = db;
            //double dbResult = (double)objDouble;
            //Console.WriteLine(dbResult);
            #endregion

            #region Deyerleri object arraya yigmaq
            //object[] array = new object[10];
            //array[0] = 35;
            //array[1] = 18.2;
            //array[2] = "Emin";
            //array[3] = true;
            //array[4] = 'C';
            //array[5] = false;
            //array[6] = "Test";
            //array[7] = 99;
            //array[8] = "GS";
            //array[9] = 5;
            //int[] intArr = new int[10];
            //string[] stringArr = new string[10];


            //int intIndex = 0;
            //int strIndex = 0;

            //foreach (var item in array)
            //{
            //    if (item is int)
            //    {
            //        intArr[intIndex] = (int)item;
            //        intIndex++;
            //    }
            //    else if (item is string)
            //    {
            //        stringArr[strIndex] = (string)item;
            //        strIndex++;

            //    }
            //}
            //for (int i = 0; i < intIndex; i++)
            //{
            //    Console.WriteLine(intArr[i]);
            //}
            //for (int i = 0; i < strIndex; i++)
            //{
            //    Console.WriteLine(stringArr[i]);
            //}
            #endregion
        }
        #region Instance sayi hesablamaq 
        //public class MyClass
        //{
        //    public static int Count { get; set; }
        //    public MyClass()
        //    {
        //        Count++;
        //    }
        //}
        #endregion


        //static void Calculator(int num1, int num2,ref int sum)
        //{
        //    num1 = 22;
        //    num2 = 48;
        //    sum = num1 + num2;
        //}
    }
}
