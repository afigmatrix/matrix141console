using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tapsiriq1
            //try
            //{
            //    int[] IntArr = new int[5];
            //   int GetArrIndex=Convert.ToInt32(Console.ReadLine());
            //    if(GetArrIndex>=5)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (SystemException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("her iki halda da calisir");
            //}
            #endregion
            #region tapsiriq2
            //string num1 =Console.ReadLine();
            //string num2=Console.ReadLine();
            //try
            //{
            //    if (int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
            //    {
            //        int sum = number1 + number2;
            //    }
            //    else
            //    {
            //        throw new FormatException();
            //    }
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch(ApplicationException ex1)
            //{
            //    Console.WriteLine(ex1.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Hesablama bitdi.");
            //}
            #endregion
            #region tapsiriq3
            //Dictionary<string, string> phone = new Dictionary<string, string>();
            //Console.Write("bir eded daxil edin:");
            //int GetPersonCount = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < GetPersonCount; i++)
            //{
            //    phone.Add(Console.ReadLine(), Console.ReadLine());
            //}
            //Console.Write("ad daxil edin:");
            //string AnyPersonName = Console.ReadLine();
            //if (phone.TryGetValue(AnyPersonName, out string AnyPerson))
            //    {
            //    Console.WriteLine($"bu şəxsin telefon nomresi:{AnyPerson}");
            //    }
            //else
            //{
            //    Console.WriteLine("bele bir şəxs yoxdur");
            //}
            #endregion
            #region tapsiriq4
            //HashSet<string> set = new HashSet<string>();
            //List<string> list = new List<string>();
            //Console.Write("bir say daxil edin:");
            //int GetCount = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < GetCount; i++)
            //{
            //    Console.Write($"{i+1}- deyeri daxil edin:");
            //    string AddHashSet = Console.ReadLine();
            //    set.Add(AddHashSet);
            //}
            //    Dictionary<string, int> dictionaryFromHashSet = new Dictionary<string, int>();

            //foreach (var item in set)
            //{
            //    dictionaryFromHashSet[item] = item.Length;
            //}
            //Console.WriteLine("HashSet'den yaranan Dictionary:");
            //foreach (var GetDictionary in dictionaryFromHashSet)
            //{
            //    Console.WriteLine($"{GetDictionary.Key}: {GetDictionary.Value}");
            //}
            //Console.Write("yoxlamaq istediyiniz email'i daxil edin:");
            //string GetEmailName= Console.ReadLine();
            //if(dictionaryFromHashSet.TryGetValue(GetEmailName,out string EmailName))
            //{
            //    Console.WriteLine($"tekrarlanan email:{EmailName}");
            //}
            //else
            //{
            //    Console.WriteLine("bele bir email yoxdur");
            //}
            #endregion
        }
    }
}
