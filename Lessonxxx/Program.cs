using System;
using System.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  //İki olculu arrayda elementlerin icinde gezib 2 - ə tam bölünən ədədləri bir tək ölçülü arraya yığın.
            //int[,] array = new int[2,10] { { 15, 83, 6, 41, 26, 54, 80, 91, 102,104 }, { 10, 23, 60, 37, 66, 113, 88, 38, 98 ,444 } };
            //int[] newArr = new int[10];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //  for (int j = 0; j < array.GetLength(1); j++)
            //  {
            //        if (array[i,j] % 2 == 0)
            //        {
            //            newArr[i] = array[i,j];
            //            Console.WriteLine(newArr[i]);
            //        }
            //  }
            #endregion

            #region// Istifadəçidən vergüllə ayrılan ədədlər alın və bir arraya yığın.Sonra isə bu arraydaki elementləri
            // arrayi tərsinə çevirib başqa bir arrayda yığın.Sort etmirsiz sadəcə arrayı tərsinə çevirirsiz.


            //    Console.WriteLine("Vergulle ayrilan ededleri daxil edin");

            //    string userNums = Console.ReadLine();
            //    if (!userNums.Contains(','))
            //    {
            //        Console.WriteLine("Duzgun elementler daxil etmediz!");
            //    }

            //    Method(userNums);

            //}
            //static void Method(string method)
            //{
            //    string[] numsArr = method.Split(',');

            //    string[] splitNums = numsArr;

            //    for (int i = 0; i < splitNums.Length / 2; i++)
            //    {
            //        string count = splitNums[i];
            //        splitNums[i] = splitNums[splitNums.Length - 1 - i];
            //        splitNums[splitNums.Length - 1 - i] = count;
            //    }
            //    foreach (string nums in splitNums)
            //    {
            //        Console.WriteLine(nums);
            //    }

            #endregion

            #region //İstifadəçidən əvvəlcə vergül ilə ayrılan 10 hərf yaxud rəqəm alın və bir arrayda toplayın.
            //Sonra yenə vergül ilə ayrılan 10 hərf yaxud rəqəm alın və bir arrayda toplayın.
            // əlinizdəki iki arrayin icində olan elementlərdən bir birinə bərabər olanlarını console - a çıxarın

            //Console.WriteLine("Vergulle ayrilan ilk elementleri daxil edin:");
            //string input1 = Console.ReadLine();

            //Console.WriteLine("Novbeti elementleri daxil edin:");
            //string input2 = Console.ReadLine();

            //string[] splitInput1 = input1.Split(',');
            //string[] splitInput2 = input2.Split(',');

            //Console.WriteLine("Beraber olan elementler");
            //for (int i = 0; i < splitInput1.Length; i++)
            //{
            //    for (int j = 0; j < splitInput2.Length; j++)
            //    {
            //        if (splitInput1[i] == splitInput2[j])
            //        {

            //            Console.WriteLine(splitInput1[i]);

            //        }
            //    }
            //}
            #endregion

            #region//İstifadəşidən bir array alın və o arrayı özünüz sort edin.

            //Console.WriteLine("Array elementlerin daxil edin");
            //int input = int.Parse(Console.ReadLine());

            //int[] myArr = new int[input];

            //for (int i = 0; i < input; i++)
            //{
            //    Console.WriteLine($"Element {i + 1}: ");
            //    myArr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(myArr);
            //foreach(int array in myArr)
            //{
            //    Console.WriteLine(array + " ");
            //}
            #endregion




        }

    }

}

