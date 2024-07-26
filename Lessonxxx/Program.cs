using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 
            #region 
            //List<int> ededKvadrati = new List<int>() { 1, 2, 3, 4, 5 };
            //var kvadrat = ededKvadrati.Select(m => m * m);

            //Console.WriteLine("Ededlerin Kvadratlari: ");
            //foreach (var kvadrati in kvadrat)
            //{
            //    Console.WriteLine(kvadrati);
            //}
            #endregion

            //Task2
            #region
            //List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            //var even = ints.Where(m => m % 2 == 0);

            //Console.WriteLine("Cut Ededler: ");
            //foreach (int  i in even)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //Task3
            #region
            //List<string> adSiralamsi = new List<string>() { "Alim", "Cefer", "Galatasaray", "Babek" };
            //var siralama = adSiralamsi.OrderBy(m => m).ToList();

            //Console.WriteLine("Adlarin Siralanmasi: ");
            //foreach (var s in siralama)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            //Task4
            #region
            //List<string> adUzunluq = new List<string>() { "Tima", "Anar", "Deniz", "Tv" };
            //var uzunluq = adUzunluq.Select(m => m.Length).ToList();

            //Console.WriteLine("Ad Uzunluq: ");
            //foreach (var u in uzunluq)
            //{
            //    Console.WriteLine(u);
            //}
            #endregion

            //Task6
            #region
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //var sum = list.Sum();

            //Console.WriteLine("Cem: " + sum);
            #endregion

            //Task7
            #region
            //List<int> list = new List<int>() { 5, 8, 9, 11, 22, 6 };

            //double average = list.Average(m=>m);

            //Console.WriteLine("The average is : " +average);
            #endregion

            //Task8
            #region
            //List<int> number = new List<int>() { 6, 11, 2, 5, 10, 0, 1, 3 };
            //var result = number.Where(m => m > 3);

            //Console.WriteLine("Ededlerin Ortalamasi: ");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            //Task9
            #region

            //List<int> num = new List<int>() { 11, 5, 9, 6, 55, 7 };
            //var azalanSira = num.OrderByDescending(m => m);

            //Console.WriteLine("Ededlerin Azalan siraya gore: ");
            //foreach (int i in azalanSira)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //Task10
            #region
            //List<string> metinSetir = new List<string>()
            //{
            //    "Galata",
            //    "Matrix Academy",
            //    "Academy",
            //    "Saray"

            //};

            //var setir = metinSetir.Where(m => m.Length > 5);

            //Console.WriteLine("Metn Setirlerini Filtirlemek: ");
            //foreach (var metin in setir)
            //{
            //    Console.WriteLine(metin);
            //}
            #endregion

        }
    }
}
