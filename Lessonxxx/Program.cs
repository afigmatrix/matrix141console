using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Verilmiş arraydan bir elementi çıxaran bir proqram yazın. Əgər istifadəçi array olmayan bir indeks sorğulasa, bu səhvi tutub
            //ekrana mesaj çıxarın. Hər halda, proqramın sonunda "Element çıxarma prosesi bitdi" mesajı çıxmalıdır.Arrayi normal array
            //olaraq yaradin.

            //int[] arr = new int[10] { 2, 4, 5, 6, 7, 8, 9, 1, 10, 20 };
            //Console.Write("Zehmet olmasa cixarmaq istediyiniz elementin indeksini daxil edin:");
            //int index = int.Parse(Console.ReadLine());
            //try
            //{
            //    if (index < 0 || index >= arr.Length)
            //    {
            //        throw new IndexOutOfRangeException("Gösterilen indeks arrayimizin indeksine uygun gelmir");
            //    }
            //    arr = Remove_element(index,arr);
            //    Console.WriteLine("Verilmis indekse uygun element cixarildi, Yeni Arrayimiz:");
            //    foreach(var numbers in arr)
            //    {
            //        Console.WriteLine(numbers);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region task2
            //İstifadəçidən iki ədəd alın və onların cəmini hesablayan bir proqram yazın.Əgər istifadəçi ədəd daxil etməzsə və ya yanlış formatda ədəd
            //daxil edərsə, bu səhvi tutub ekrana error mesaj çıxarın. Hər halda, proqramın sonunda "Hesablama bitdi" mesajı çıxmalıdır.

            //try
            //{
            //    Console.Write("Num1:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Num2:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int cem = Cem(num1, num2);
            //    Console.WriteLine(cem);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(typeof(Exception));
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Hesablama bitdi!");
            //}
            #endregion
            #region task3
            //Dictionary<string, string> dic = new Dictionary<string, string>()
            //{
            //    { "Turkay", "123456" },
            //    { "Nuray", "654321" },
            //    { "Ayan", "111222" },
            //    { "Nermine", "333444" }
            //};
            //Console.Write("Elave etmek istediyiniz adi daxil edin:");
            //string name = Console.ReadLine();
            //Console.Write("Elave etmek istediyiniz telefon nomresini daxil edin:");
            //string telephone_number = Console.ReadLine();
            //Console.WriteLine("Yeni siyahimiz:");
            //dic = Siyahi(dic, name, telephone_number);
            //foreach (KeyValuePair<string, string> new_dic in dic)
            //{
            //    Console.WriteLine($"Ad:{new_dic.Key} Telefon nomresi:{new_dic.Value}");
            //}
            //while (true)
            //{
            //    Console.WriteLine("Lazim olan Adi qeyd edin:");
            //    string include_name_fromUser = Console.ReadLine();
            //    if (include_name_fromUser == "exit")
            //    {
            //        break;
            //    }
            //    if (dic.TryGetValue(include_name_fromUser, out telephone_number))
            //    {
            //        Console.WriteLine($"Ad:{include_name_fromUser} Telefon nomresi:{telephone_number}");
            //    }
            //}
            #endregion
            #region task4
            //HashSet<string> emailSet = new HashSet<string>
            //{
            //    "turkay@example.com",
            //    "nuray@example.com",
            //    "ayan@example.com",
            //    "nermine@example.com"
            //};
            //while (true)
            //{
            //    Console.Write("Elave etmek istediyiniz mail adresini daxil edin:");
            //    string add_email = Console.ReadLine();
            //    if (add_email == "exit")
            //    {
            //        break;
            //    }
            //    emailSet.Add(add_email);
            //}
            //foreach (var new_email_set in emailSet)
            //{
            //    Console.WriteLine(new_email_set);
            //}
            //string check_email = Console.ReadLine();
            //if (emailSet.Contains(check_email))
            //{
            //    Console.WriteLine("Bu email movcudur");
            //}
            //else
            //{
            //    Console.WriteLine("Bu email movcud deyil");
            //}
            #endregion

            //Task1 ucun yazdigim method
            static int[] Remove_element(int index, int[] arr)
            {
                int[] new_arr = new int[arr.Length - 1];
                for (int i = 0, j = 0; i < new_arr.Length; i++)
                {
                    if (index == i)
                    {
                        continue;
                    }
                    new_arr[j] = arr[i];
                    j++;
                }
                return new_arr;
            }
            //Task2 ucun yazdigim method
            static int Cem(int num1, int num2)
            {
                return (num1 + num2);
            }
            //Task3 ucun yazdigim method
            static Dictionary<string, string> Siyahi(Dictionary<string, string> dic, string name, string telephone_number)
            {
                dic.Add(name, telephone_number);
                return dic;
            }
        }
    }
}
