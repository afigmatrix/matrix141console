using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Tapşırıq 1: Ədədlərin Kvadratları
            //Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək
            //bu ədədlərin kvadratlarını əldə edin.

            //List<int> list = new List<int>() { 2,3,4,5,6};
            //var kvadrat=list.Select(x =>x*x) .ToList();
            //foreach(var new_list in kvadrat)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task2
            //Tapşırıq 2: Cüt Ədədləri Filtrləmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahıdan cüt ədədləri seçin.

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //List<int> even=list.Where(m=>m%2==0).ToList();
            //foreach(var new_list in even)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task3
            //Tapşırıq 3: Adları Sıraya Görə Birləşdirmək
            //Bir adlar siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək adları əlifba sırasına görə düzün.

            //List<string> list = new List<string>() {"Turkay", "Narmina","Ayan","Sevil","Leman","Seide","Fidan"};
            //var elifba_sirasi=list.OrderBy(x => x).ToList();
            //foreach(var new_list in elifba_sirasi)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task4
            //Tapşırıq 4: Adların Uzunluqlarını Almaq
            //Bir adlar siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək hər bir adın uzunluğunu əldə edin.

            //List<string> list = new List<string>() { "Turkay", "Narmina", "Ayan", "Sevil", "Leman", "Seide", "Fidan" };
            //var adlarin_uzunlugu=list.Select(x=>x.Length).ToList();
            //foreach(var new_list in adlarin_uzunlugu)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task5
            //Tapşırıq 6: Ədədlərin Cəmi
            //Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu ədədlərin cəmini hesablayın.

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //int Sum=list.Sum(x => x);
            //Console.WriteLine(Sum);
            #endregion
            #region task6 
            //Tapşırıq 7: Ədədlərin Ortalaması
            //Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu ədədlərin ortalamasını hesablayın.

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var ededi_orta = list.Average(x => x);
            //Console.WriteLine(ededi_orta);
            #endregion
            #region task7
            //Tapşırıq 8: 3 - dən Böyük Ədədləri Filtrləmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahıdan 3 - dən böyük
            //ədədləri seçin.

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var filtering=list.Where(x=>x>3).ToList();
            //foreach(var new_list in filtering)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task8
            //Tapşırıq 9: Ədədləri Azalan Sıraya Görə Düzmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahını azalan sıraya görə düzün.

            //List<int> ededler = new List<int> { 4,5, 3, 8, 1, 2 };
            //var azalanSirayaGore = ededler.OrderByDescending(eded => eded).ToList();
            //foreach (var new_list in azalanSirayaGore)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion
            #region task9
            //Tapşırıq 10: Mətn Sətirlərini Filtrləmək
            //Bir mətn sətirləri siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu siyahıdan
            //uzunluğu 5 - dən böyük olan mətn sətirlərini seçin.

            //List<string> list = new List<string>() { "Turkay","Mehseti" , "Ayan", "Sevil", "Leman", "Seide", "Fidan","Narmina"};
            //var duzulmus_list=list.Where(m=>m.Length>5).ToList();
            //foreach(var new_list in duzulmus_list)
            //{
            //    Console.WriteLine(new_list);
            //}
            #endregion

        }
    }
}
