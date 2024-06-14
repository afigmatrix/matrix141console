using System;
using System.Collections;
using System.Numerics;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        #region do-while
        static void doWhile()
        {
            //string value = Console.ReadLine();
            //if (value.Length < 10)
            //{
            //    while (true)
            //    {
            //        string value2 = Console.ReadLine();
            //        if (value2.Length > 10)
            //        {
            //            Console.WriteLine("Value is valid");
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Value is valid without while");
            do
            {
                string value2 = Console.ReadLine();
                if (value2.Length > 10)
                {
                    Console.WriteLine("Value is valid");
                    break;
                }
            }
            while (true);
          

        }
        #endregion
        #region SwitchWhen
        static void SwichWhen()
        {
            string name = "Matrix";
            switch (name)
            {
                case string name2 when name.StartsWith("M"):
                    Console.WriteLine("Name start with M");
                    break;
            }
        }
        #endregion
        #region Continue
        static void Continue()
        {
            int count = 40;
            for (int i = 0; i < count; i++)
            {
                if (i == 25 || i == 30)
                {
                    return;
                }
                Console.WriteLine(i);
            }
        }
        #endregion
    }
}



//switch (caseSwitch)
//{
//    ...
//    case TypeA myVar when myVar.Size > 0:
//    ...
//        break;
//case < type> < variable_name > when<any_boolean_expression>:
//        ...
//        break;
//    ...
//}