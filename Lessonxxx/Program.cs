using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            //Console.WriteLine("Vergul ile ayrilan deyerleri daxil edin !");
            //string userInput = Console.ReadLine();

            //if (!userInput.Contains(','))
            //{
            //    Console.WriteLine("Duzgun melumat daxil etmediniz!");
            //    return;
            //}

            //string[] splittedData = userInput.Split(',');

            //if (splittedData.Length < 10)
            //{
            //    Console.WriteLine("Duzgun melumat daxil etmediniz!");
            //    return;
            //}

            //string[] newArray = new string[10];
            //int newArrI=0;
            //for (int i = 0; i < splittedData.Length; i++)
            //{
            //    if (splittedData[i].Length > 5)
            //    {
            //        newArray[newArrI] = splittedData[i];
            //        Console.WriteLine($"newArr[{newArrI}] = spliteddData[{i}]");
            //        newArrI++;
            //    }
            //}
            #endregion

            int[] intArr = new int[10];


            int[,] jArr = new int[2, 5];

            int[,] numbers =
            {
                { 1, 4, 2,4,2}, //0
                {3, 6, 8, 6, 8} //1
            };  //0, 1, 2, 3, 4

            Console.WriteLine(numbers.GetLength(0));
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int ji = 0; ji < numbers.GetLength(1); ji++)
                {
                    Console.WriteLine($"{i}-elementin ->  {ji}-si = {numbers[i, ji]}");
                }
            }

            int[] myArr = new int[] { 23, 5, 1, 2, 64, 67, 34, 223, 4, 54, 57, 3 };
            Array.Sort(myArr);
            int a = 6;
        }
    }
}
