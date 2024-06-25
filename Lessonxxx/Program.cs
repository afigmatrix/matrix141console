using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vergul ile sozler yazin");
            
            #region Task1
            //string[] names = { "Emin", "Turkay", "Teymur", "Revan", "Hemze", "Ferid", "Hemid" };
            //char character = '-';
            //Console.WriteLine("Result:");
            //Console.WriteLine(CustomJoin(names, character));
            #endregion
            #region min
            //int[] numberlist = new int[5];
            //for (int i = 0; i < numberlist.Length; i++) { 
            //    numberlist[i] = int.Parse(Console.ReadLine());
            //}         
            //Console.WriteLine("min number:" + findmin(numberlist));
            #endregion
            #region average
            //int[] numberlist = new int[5];
            //for (int i = 0; i < numberlist.Length; i++)
            //{
            //    numberlist[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("average number:" + FindAverage(numberlist));
            #endregion
        }
        #region Task1
        //static string CustomJoin(string[] names, char character)
        //{
        //    string result = " ";
        //    if (names.Length > 500)
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            sb.Append(names[i]);
        //            if (i < names.Length - 1)
        //            {
        //                sb.Append(character);
        //            }
        //        }

        //        return sb.ToString();
        //    }

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        result += names[i];

        //        if (i < names.Length - 1)
        //            result += character;
        //    }
        //    return result;
        //}
        #endregion Task1
        #region min
        //static int findmin(int[] numberlist)
        //{
        //    int min = numberlist[0];
        //    for (int i = 1; i < numberlist.Length; i++)
        //    {
        //        if (numberlist[i] < min)
        //        {
        //            min = numberlist[i];
        //        }
        //    }
        //    return min;
        //} 
        #endregion
        #region average
        //static int FindAverage(int[] numberlist)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numberlist.Length; i++)
        //    {
        //        sum += numberlist[i];
        //    }
        //    return sum / numberlist.Length;
        //}
        #endregion
        static string[] CustomSplit(string words)
        {

            string[] split = words.Split(',');
            int count = 0;
            foreach (string word in words)
            {
                if (word.Length > 5)
                {
                    count++;
                }

            }
            string[] longwords = new string[count];
            int i = 0;
            foreach (string word in words)
            {
                if (word.Length > 5)
                {
                    longwords[i] = word;
                    i++;
                }
                return longwords;
            }

        }
    }
}
