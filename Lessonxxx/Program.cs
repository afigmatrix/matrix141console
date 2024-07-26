using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq 1: Ədədlərin Kvadratları
            // Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu ədədlərin kvadratlarını əldə edin.

            //List<int> ints = new List<int>() { 2, 3, 4, 5, 6, 7, 8 };
            //var square = ints.Select(i => i * i);
            //Console.WriteLine(string.Join(", ", square));


            //Tapşırıq 2: Cüt Ədədləri Filtrləmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahıdan cüt ədədləri seçin.

            //List<int> evenNum = new List<int>() { 1, 25, 44, 50, 38, 89, 13, 51, 22, 88, 16 };
            //var result = evenNum.Where(x => x % 2 ==0).ToList();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Tapşırıq 3: Adları Sıraya Görə Birləşdirmək
            //Bir adlar siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək adları əlifba sırasına görə düzün.

            //List<string> list = new List<string>() { "Emin", "Baki", "Developer", "Achar","Matrix" ,"Salam"};
            //var str = list.OrderBy(x=> x).ToList();
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}


            //Tapşırıq 4: Adların Uzunluqlarını Almaq
            //Bir adlar siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək hər bir adın uzunluğunu əldə edin.

            //List<string> list = new List<string>() { "Emin", "Baki", "Developer", "Achar", "Matrix", "Salam" };
            //var strLength = list.Select(x => x.Length).ToList();
            //foreach (var str in strLength)
            //{
            //    Console.WriteLine(str);
            //}

            // Tapşırıq 5: Ədədlərin Cəmi
            //Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu ədədlərin cəmini hesablayın.

            //List<int> intList = new List<int>() { 1, 25, 44, 50, 38, 89, 13, 51, 22, 88, 16 };
            //var result = intList.Sum(x => x);
            //Console.WriteLine(result);

            //Tapşırıq 6: Ədədlərin Ortalaması
            //Bir ədədlər siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək bu ədədlərin ortalamasını hesablayın.

            //List<int> list = new List<int>() { 5,15,1 };
            //var res = list.Average();
            //Console.WriteLine(res);

            // Tapşırıq 7: 3 - dən Böyük Ədədləri Filtrləmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahıdan 3 - dən böyük ədədləri seçin.

            //List<int> intList = new List<int>() { -5, 1, 2, 25, 44, 50, 38,  0, 13, 51, 22, 16 };
            //var result = intList.Where(x => x > 3).ToList();
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Tapşırıq 8: Ədədləri Azalan Sıraya Görə Düzmək
            //Bir ədədlər siyahısı verilib.Lambda ifadəsi və LINQ istifadə edərək bu siyahını azalan sıraya görə düzün.

            //List<int> list = new List<int>() { -5, 1, 2, 25, 44, 50, 38, 0, 13, 51, 22, 16 };
            //var res = list.OrderByDescending(x => x).ToList();
            //foreach (int i in res)
            //{
            //    Console.WriteLine(i);
            //}

            // Tapşırıq 9: Mətn Sətirlərini Filtrləmək
            //Bir mətn sətirləri siyahısı verilib. Lambda ifadəsi və LINQ istifadə edərək
            //bu siyahıdan uzunluğu 5 - dən böyük olan mətn sətirlərini seçin.

            //List<string> list = new List<string>() { "Salam", "bugun", "yene", "Matrix", "academyde", "gorusduk" };

            //var res = list.Where(x => x.Length > 5).ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
