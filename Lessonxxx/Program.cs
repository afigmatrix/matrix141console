using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //ValueType - den Objecte ve Objectden ValueType -e Boxing - Unboxinge aid 5 numune yazin
            //int number = 39;
            //Object boxednumber = number;
            //int unboxednumber=(int)boxednumber;

            //char letter2 = 'c';
            //Object boxedletter2 = letter2;
            //char unboxednletter2=(char)boxedletter2;

            //double pi = 3.14;
            //Object boxedpi = pi;
            //double unboxedpi=(double)boxedpi;

            //string word = "string";
            //Object boxedword = word;
            //string unboxedword=(string)boxedword;

            //bool istrue = true;
            //Object boxedistrue = istrue;
            //bool unboxedistrue=(bool)boxedistrue;
            #endregion
            #region task2
            //Object[] arr = new Object[10];
            //arr[0] = 1;
            //arr[1] = 'k';
            //arr[2] = "kitab";
            //arr[3] = 3.14;
            //arr[4] = 5;
            //arr[5] = "qelem";
            //arr[6] = 2.56;
            //arr[7] = "defter";
            //arr[8] = 'a';
            //arr[9] = 4;
            //string[] string_arr=new string[10];
            //int[] int_arr=new int[10];
            //int int_index = 0;
            //int string_index = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] is int)
            //    {
            //        int_arr[int_index] = (int)arr[i];
            //        Console.Write($"int_arr[{int_index}]:");
            //        Console.WriteLine(int_arr[int_index]);
            //        int_index++;
            //    }
            //    else if (arr[i] is string)
            //    {
            //        string_arr[string_index] = (string)arr[i];
            //        Console.Write($"string_arr[{string_index}]:");
            //        Console.WriteLine(string_arr[string_index]);
            //        string_index++;
            //    }
            //}
            #endregion
            #region task3
            //int Result = default;
            //Calculate(3,4,ref Result);
            //Console.WriteLine(Result);
            #endregion
            #region task4
            //People people = new People();
            //People people1 = new People(); 
            //People people2 = new People();
            //People people3= new People();
            //Console.WriteLine(People.instancecount);
            #endregion
        }
        static void Calculate(int num1,int num2, ref int Result)
        {
            Result = num1 + num2;
        }
    }
    public class People
    {
        public static int instancecount;
        public People()
        {
            instancecount++;
        }
    }
}
