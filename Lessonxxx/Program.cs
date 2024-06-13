using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //Console.WriteLine("Soz daxil edin!");
            //string soz = Console.ReadLine();
            // bool result = Method(soz);
            // Console.WriteLine(result);


           

            Console.WriteLine("Deyer daxil edin");

            while (true)
            {
                string deyer = Console.ReadLine();
                if (deyer.Length <= 10)
                {
                    Console.WriteLine("Deyer 10dan kicikdir yeniden daxil edin");
                }
                else if (deyer.Length > 10)
                {
                    Console.WriteLine($"Daxil etdiyiniz deyer = {deyer}");
                    break;
                }

            }

        }
    }

}
//        static bool Method (string name)
//        {
//            if (name.StartsWith('a') || name.StartsWith('b') || name.StartsWith('c'))
//            {
//                return true;
//            }
//            else
//                return false;

//        }
//    }  
//}

