using System;
using System.Text;

namespace Lessonxxx
{
    internal class Program
    {
        //Task1
        #region
        //static void Main(String[] args)
        //{
        //    string[] words = new string[] { "Emin", "Turkay", "Teymur", "Revan", "Hemze", "Ferid", "Hemid" };
        //    string character = string.Join("-", words);
        //    Console.WriteLine(character);
        //    Console.WriteLine(CustomJoin(words, "-"));
        //}


        //static string CustomJoin(string[] words, string character)
        //{
        //    if (words.Length > 500)
        //    {
        //        StringBuilder st = new StringBuilder();
        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            st.Append(words[i]);
        //        }
        //        return st.ToString();
        //    }
        //    else
        //    {
        //        string result = string.Empty;

        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            result += words[i] + character;
        //        }

        //        return result.Trim('-');
        //    }
        //}
        #endregion

        //Task2

        #region
        //static void Main(string[] args)
        //{
        //    int[] numbers = new int[] { 3,19,7,8,5,2 };
        //    Console.WriteLine(FindMin(numbers));
        //}

        //static int FindMin(int[] numbers)
        //{
        //    int min = numbers[0];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < min)
        //        {
        //            min = numbers[i];
        //        }
        //    }
        //    return min;
        //}
        #endregion

        //Task3
        #region
        //static void Main(String[] args)
        //{
        //    int[] numberList = new int[] { 5, 10, 8, 19, 3, 17, 6 };
        //    Console.WriteLine(FindAvarege(numberList));

        //}

        //static int FindAvarege(int[] numberList)
        //{
        //    int sum = numberList[0];
        //    for (int i = 1; i < numberList.Length; i++)
        //    {
        //        sum += numberList[i];
        //    }
        //    int average = sum / numberList.Length;
        //    Console.WriteLine(sum + " / " + numberList.Length);

        //    return average;
        //}
        #endregion

        //task4
        #region
        //static void Main(string[] args)
        //{
        //Task4

        //    string word = ("kitab,komputer,cpu,sebeke,insan,televizor,telefon,valyuta,klavyatura,BMW");
        //    string[] newtest = st(word);

        //    for (int i = 0; i < newtest.Length; i++)
        //    {
        //        Console.WriteLine(newtest[i]);
        //    }
        //}

        //static string[] st(string word)
        //{
        //    string[] wordList = word.Split(',');

        //    string[] newordList = new string[wordList.Length];

        //    int n = 0;
        //    for (int i = 0; i < wordList.Length; i++)
        //    {
        //        if (wordList[i].Length > 5)
        //        {
        //            newordList[n] = wordList[i];
        //            n++;
        //        }
        //    }
        //    return newordList;
        //}
        #endregion

        //Task elave multiplication
        #region
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"**********{i}**********");
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }
            }
            Console.ReadLine();
        }

        #endregion


    }

}
