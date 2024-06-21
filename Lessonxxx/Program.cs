using System;
using System.Collections;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArr = new int[9];
            //Array.Resize(ref myArr, 15 );
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine(myArr[i]); //get
            //}


            //string name = "Mat";
            //char M = 'M';
            //char a = 'a';
            //char t = 't';

            //char[] charArr = name.ToCharArray();
            //for (int i = 0; i < charArr.Length; i++)
            //{
            //    Console.WriteLine((int)charArr[i]);
            //}


            ////string kapitalBankPrefix = "4169";
            ////string abbPrefix = "5522";

            //string userCard = "4169-7388-3689-7924,5588-7839-9392-0834";
            //string[] userCardList = userCard.Split(',');


            //for (int i = 0; i < userCardList.Length; i++)
            //{
            //    string userPrefix = userCardList[i].Split("-")[0];


            //    if (userPrefix == kapitalBankPrefix)
            //    {
            //        Console.WriteLine("Kapital Bank");
            //        continue;
            //    }
            //    if (userPrefix == abbPrefix)
            //    {
            //        Console.WriteLine("Beynelxalq Bank");
            //        continue;
            //    }
            //}


            //int result = Sum(1, 4, 5, 5, 2, 24, 53, 53, 2, 1, 32, 35, 53, 2, 42);
            //Console.WriteLine(result);

            string[] studentNameList = new string[] { "Emin", "Turkay", "Teymur", "Revan", "Hemze", "Ferid", "Hemid" };
            string joinedSL = string.Join('-', studentNameList);
            Console.WriteLine(joinedSL);


            //foreach (var studentName in studentNameList)
            //{
            //    Console.WriteLine(studentName);
            //}

        }

        static int Sum(int character,int param2,int age, params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
