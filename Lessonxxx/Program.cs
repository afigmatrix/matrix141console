using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vergul ile ayrilan deyerleri daxil edin !");
            string userInput = Console.ReadLine();

            if (!userInput.Contains(','))
            {
                Console.WriteLine("Duzgun melumat daxil etmediniz!");
                return;
            }

            string[] splittedData = userInput.Split(',');

            if (splittedData.Length > 10)
            {
                Console.WriteLine("Duzgun melumat daxil etmediniz!");
                return;
            }

            string[] newArray = new string[10];

            for (int i = 0; i < splittedData.Length; i++)
            {
                if (splittedData[i].Length > 5)
                {
                    newArray[i] = splittedData[i];
                    Console.WriteLine($"newArr[{i}] = spliteddData[{i}]");
                }
                else
                {
                    Console.WriteLine($"newArr[{i}] = null");

                }
            }


        }
    }
}
