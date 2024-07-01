using System;
using System.Xml.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int new_arr_length = 0;
            //int[,] arr = new int[2, 3];
            //int[] new_arr = new int[6];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"arr[{i},{j}]:");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //        if (arr[i, j] % 2 == 0)
            //        {
            //            new_arr[new_arr_length] = arr[i, j];
            //            new_arr_length++;
            //        }
            //    }
            //}
            //for (int i = 0; i < new_arr_length; i++)
            //{
            //    Console.Write($"new_arr[{i}]:");
            //    Console.WriteLine(new_arr[i]);
            //}
            #endregion
            #region task3
            //Console.Write("Vergulle ayrilmis ededleri daxil edin=");
            //string letters = Console.ReadLine();
            //string[] arr=letters.Split(',');
            //string[] new_arr= new string[arr.Length];
            //int new_arr_indeks = 0;
            //for(int i=arr.Length-1; i>=0; i--)
            //{
            //    new_arr[new_arr_indeks] = arr[i];
            //    new_arr_indeks++;
            //}
            //for(int i=0; i<new_arr.Length; i++)
            //{
            //    Console.WriteLine($"new_arr[{i}]={new_arr[i]}");    
            //}
            #endregion
            #region task4
            //Console.Write("Vergulle ayrilan 10 eded daxil edin=");
            //string first_numbers=Console.ReadLine();
            //Console.Write("Vergulle ayrilan 10 eded daxil edin=");
            //string second_numbers=Console.ReadLine();
            //string[] first_arr=first_numbers.Split(',');
            //string[] second_arr=second_numbers.Split(',');
            //for(int i = 0; i < first_arr.Length; i++)
            //{
            //    for(int j = 0; j < second_arr.Length; j++)
            //    {
            //        if (second_arr[j] == first_arr[i])
            //        {
            //            Console.WriteLine(second_arr[j]);
            //        }
            //    }
            //}

            #endregion
            #region task5
            //int[] arr = new int[7];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"arr[{i}]");
            //    arr[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] >= arr[j])
            //        {
            //            int evezedici = default;
            //            evezedici = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = evezedici;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"arr[{i}]={arr[i]}");
            //}
            #endregion
        }
    }
}
