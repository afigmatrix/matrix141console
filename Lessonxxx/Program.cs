using System;
using System.Text;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //string[] names = { "Emin", "Turkay", "Teymur", "Revan", "Hemze", "Ferid", "Hemid" };
            //string character = "-";
            //Console.WriteLine(Customjoin(names, character));
            #endregion
            #region task2
            //int[] for_founding_min = { 3, 2, 8, 6, 18, 15 };
            //Console.WriteLine(FindMin(for_founding_min));
            #endregion
            #region task3
            //int[] for_founding_avarage = { 3, 2, 8, 6, 14, 15 };
            //Console.WriteLine(FindAvarage(for_founding_avarage));
            #endregion
            #region task4
            string text = "Kitab,Defter,Agac,Qelem,Gul";


            string[] text_array = text.Split(',');
            string[] final_array = new string[text_array.Length];

            for (int i = 0; i < text_array.Length; i++)
            {
                if (text_array[i].Length >= 5)
                {
                    final_array[i] = text_array[i];
                    Console.WriteLine(final_array[i]);
                }
            }
            #endregion
        }
        static string Customjoin(string[] words, string character)
        {
            string newtext = default;
            if (words.Length < 500)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    newtext += words[i];
                    if (i == words.Length - 1)
                    {
                        break;
                    }
                    newtext += "-";
                }
                return newtext;

            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    sb.Append(words[i]);
                    if (i == words.Length - 1)
                    {
                        break;
                    }
                    sb.Append(character);
                }
                newtext = sb.ToString();
                return newtext;
            }
            return character;
        }
        static int FindMin(int[] NumberList)
        {
            int min = NumberList[0];
            for (int i = 0; i < NumberList.Length; i++)
            {
                if (NumberList[i] < min)
                {
                    min = NumberList[i];
                }
            }
            return min;
        }
        static int FindAvarage(int[] NumberList)
        {
            int sum = 0;
            for (int i = 0; i < NumberList.Length; i++)
            {
                sum += NumberList[i];
            }
            int avarage = sum / NumberList.Length;

            return avarage;
        }
    }
}
