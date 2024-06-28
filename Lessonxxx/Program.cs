using System;

namespace Lessonxxx
{
    internal class Program
    {
        //Task1

        #region

        //static void Main(string[] args)
        //{
        //    int[,] numbers =
        //    {
        //         {1,5,7,8,12,14 },


        //        { 22,25,32,11,10,88}

        //    };
        //    print2(numbers);
        //    int[] newArr = evenNumbers(numbers);
        //    print1(newArr);

        //}

        //static void print1(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        //static void print2(int[,] numbers)
        //{
        //    for (int i = 0; i < numbers.GetLength(0); i++)
        //    {
        //        for (int g = 0; g < numbers.GetLength(1); g++)
        //        {
        //            Console.WriteLine($"{i} - element = {numbers[i, g]}");
        //        }

        //    }
        //}

        //static int[] evenNumbers(int[,] numbers)
        //{
        //    int maxElementSayi = numbers.GetLength(0) * numbers.GetLength(1);

        //    int[] tempArr = new int[maxElementSayi];

        //    int x = 0;
        //    for (int i = 0; i < numbers.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < numbers.GetLength(1); j++)
        //        {
        //            if (numbers[i, j] % 2 == 0)
        //            {
        //                tempArr[x] = numbers[i, j];
        //                x++;
        //            }
        //        }
        //    }

        //    int[] sonMassiv = new int[x];
        //    for (int i = 0; i < sonMassiv.Length; i++)
        //    {
        //        sonMassiv[i] = tempArr[i];
        //    }

        //    return sonMassiv;
        //}
        #endregion


        //Task2

        #region

        //static void Main(String[] args)
        //{
        //    Console.WriteLine("Please enter sentence");
        //    string sentence = Console.ReadLine();

        //    sentence = sentence.ToLower();

        //    int[] frequencies = new int[26];

        //    foreach (char c in sentence)
        //    {
        //        if (char.IsLetter(c))
        //        {
        //            int index = c - 'a';
        //            frequencies[index]++;
        //        }
        //    }

        //    for (int i = 0; i < frequencies.Length; i++)
        //    {
        //        if (frequencies[i] > 0)
        //        {
        //            char letter = (char)(i + 'a');
        //            Console.WriteLine($"Letter : {letter} Frequency : {frequencies[i]}");
        //        }
        //    }


        //}

        #endregion

        //Task3
        #region
        //static void Main(String[] args)
        //{
        //    Console.WriteLine("Vergul ile ayrilan ededleri daxil edin");
        //    string numberInput = Console.ReadLine();

        //    if (!numberInput.Contains(','))
        //    {
        //        Console.WriteLine("Duzgun melumat daxil etmediniz");
        //    }

        //    newMethod(numberInput);

        //}

        //static void newMethod(string numberInput)
        //{
        //    string[] newArr = numberInput.Split(',');

        //    int uzunluq = newArr.Length;


        //    string[] tersArry = new string[uzunluq];

        //    for (int i = 0; i < tersArry.Length; i++)
        //    {
        //        tersArry[i] = newArr[uzunluq - i - 1];

        //    }

        //    for (int i = 0; i < newArr.Length; i++)
        //    {
        //        Console.Write(tersArry[i] + ',');
        //    }


        //}
        #endregion

        //Task4

        #region
        //static void Main(String[] args)
        //{
        //    Console.WriteLine("Zehmet olmasa nomreni vergulle daxil edin ");
        //    string numbers = Console.ReadLine();

        //    Console.WriteLine("Zehmet olmasa nomreni vergulle daxil edin");
        //    string word = Console.ReadLine();

        //  Print(numbers, word);
        //}

        //static void Print(string numbers,string word)
        //{
        //    string[] printS= numbers.Split(',');

        //    Console.WriteLine("");

        //    string[] fileT = word.Split(",");

        //    Console.WriteLine("\n----------------------------");

        //    for(int i = 0; i < printS.Length; i++)
        //    {
        //        for(int j = 0; j < fileT.Length; j++)
        //        {
        //            if (printS[i] == fileT[j])
        //            {
        //                Console.WriteLine(printS[i]);
        //            }
        //        }
        //    }

        //}

        #endregion

        //Task5

        #region
        //static void Main(string[] args)
        //{
        //    int[] freq_array = new int[] { 12,20,2,55,6,4,200,10};

        //    int temp;

        //    for (int i = 0; i < freq_array.Length; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (freq_array[j] > /* (<) */ freq_array[i])
        //            {
        //                temp = freq_array[i];
        //                freq_array[i] = freq_array[j];
        //                freq_array[j] = temp;
        //            }
        //        }
        //    }

        //    for (int x = 0;x < freq_array.Length; x++)
        //    {
        //        Console.WriteLine(freq_array[x]);
        //    }
        //}
        #endregion

    }

}
















