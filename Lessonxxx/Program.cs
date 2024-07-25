using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1  

            //   Tapşırıq 1: Ədədlərin Kvadratları
            //   Bir ədədlər siyahısı verilib. Lambda ifadəsi və
            //   LINQ istifadə edərək bu ədədlərin kvadratlarını əldə edin.


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //var kvadratlar = numbers.Select(a => a * a).ToList();

            //Console.WriteLine("Ededlerin kvadratları:");
            //foreach (var kvadrat in kvadratlar)
            //{
            //    Console.WriteLine(kvadrat);

            //}
            #endregion

            #region Task2

            //   Tapşırıq 2: Cüt Ədədləri Filtrləmək
            //   Bir ədədlər siyahısı verilib.Lambda ifadəsi və
            //   LINQ istifadə edərək bu siyahıdan cüt ədədləri seçin.


            //List<int> CutEdedler = new List<int> { 1,2,4,5,7,8};

            //CutEdedler.Where(x => x % 2 == 0).ToList()

            //       .ForEach(Console.WriteLine);


            #endregion

            #region Task3



            //   Tapşırıq 3: Adları Sıraya Görə Birləşdirmək
            //   Bir adlar siyahısı verilib. Lambda ifadəsi və
            //   LINQ istifadə edərək adları əlifba sırasına görə düzün.

            // List<string> adlar = new List<string> { "Ehmed", "Sefer", "Amil", "Kamil", "Asim", "Eli", "Kerim" };

            //var AdlarElifbaSirasi = adlar.OrderBy(a => a).ToList();
            // Console.WriteLine("Elifba sirasina gore adlar:");

            // foreach (var Sira in AdlarElifbaSirasi)
            // {

            //     Console.WriteLine(Sira);
            // }

            #endregion

            #region Task4


            //   Tapşırıq 4: Adların Uzunluqlarını Almaq
            //   Bir adlar siyahısı verilib.Lambda ifadəsi və
            //   LINQ istifadə edərək hər bir adın uzunluğunu əldə edin.


            //List<string> names = new List<string> { "Ehmed", "Sefer", "Amil", "Kamil", "Asim", "Eli", "Kerim" };

            //var AdlarOlcusu = names.Select(a => a.Length).ToList();

            //foreach (var length in AdlarOlcusu)
            //{
            //    Console.WriteLine(length);
            //}


            #endregion

            #region Task5

            //  Tapşırıq 6: Ədədlərin Cəmi
            //  Bir ədədlər siyahısı verilib. Lambda ifadəsi və
            //  LINQ istifadə edərək bu ədədlərin cəmini hesablayın.

            //   List<int> numbers = new List<int> { 1, 3, 4, 5, 8, 9, 10, 11 };
            //{
            //       var ededlerinCemi = numbers.Sum(a => a);

            //       Console.WriteLine(ededlerinCemi);

            //   }

            #endregion

            #region Task6

            //  Tapşırıq 7: Ədədlərin Ortalaması
            //  Bir ədədlər siyahısı verilib. Lambda ifadəsi və
            //  LINQ istifadə edərək bu ədədlərin ortalamasını hesablayın.

            //List<int> ededler = new List<int> { 2,5,3,7,9,1+3};

            //var ortalama = ededler.Average(e => e);

            //Console.WriteLine(ortalama);

            #endregion

            #region Task7

            //  Tapşırıq 8: 3 - dən Böyük Ədədləri Filtrləmək
            //  Bir ədədlər siyahısı verilib.Lambda ifadəsi və 
            //  LINQ istifadə edərək bu siyahıdan 3-dən böyük ədədləri seçin.

            //List<int> nums = new List<int> { 1,2,3,4,5,6,7};

            //var BoyukEdedler = nums.Where(a => a >3 ).ToList();

            //foreach( int a in BoyukEdedler)
            //{
            //    Console.WriteLine(a);
            //}


            #endregion

            #region Task8

            //  Tapşırıq 9: Ədədləri Azalan Sıraya Görə Düzmək
            //  Bir ədədlər siyahısı verilib.Lambda ifadəsi və 
            //  LINQ istifadə edərək bu siyahını azalan sıraya görə düzün.

            //List<int> nums = new List<int> { 2, 5, 7, 3, 1, 4, 9 }; 

            //var azalan =nums.OrderByDescending(a => a).ToList();
            //foreach (int num in azalan)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region Task9

            //       //   Tapşırıq 10: Mətn Sətirlərini Filtrləmək
            //Bir    //   mətn sətirləri siyahısı verilib. Lambda ifadəsi və
            //       //   LINQ istifadə edərək bu siyahıdan uzunluğu 5 - dən böyük olan mətn sətirlərini seçin.

            //List<string> metn = new List<string> { "Eve getmek","Televizor izlemek","Qac","Masin","Getdiler","Dur","Gelecekler"}; 

            //var metnUzunlugu = metn.Where(a => a.Length > 3).ToList();

            //Console.WriteLine("Uzunlugu 5- den boyuk metn setrleri:");

            //foreach( var uzunluq in metnUzunlugu)
            //{
            //    Console.WriteLine(uzunluq);
            //}

            #endregion
        }
    }
}
