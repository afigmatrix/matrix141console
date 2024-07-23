using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] number = new int[5];
            int userInput = int.Parse(Console.ReadLine());
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[3] = 4;
            number[4] = 5;



            try
            {
                if (userInput > number.Length) ;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine(" Əməliyyat icra olunmadı");
            }
            #endregion
            #region

            int cem = 0;
            Console.WriteLine("Birinci ededi daxil ed ");
            int eded = int.Parse(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil ed ");
            int eded2 = int.Parse(Console.ReadLine());


            try
            {
                cem = eded + eded2;
                Console.WriteLine("Cemi: " + cem);
            }
            catch (FormatException)
            {
                Console.WriteLine(" Yanlış ədəd");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Əməliyyat dayandI");
            }

            #endregion
        }
    }
}
