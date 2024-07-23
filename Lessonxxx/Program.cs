using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş arraydan bir elementi çıxaran bir proqram yazın.
            // Əgər istifadəçi array olmayan bir indeks sorğulasa, bu səhvi tutub ekrana mesaj çıxarın.
            // Hər halda, proqramın sonunda "Element çıxarma prosesi bitdi" mesajı çıxmalıdır.
            // Arrayi normal array olaraq yaradin.

            int[] myArr = new int[5] { 5, 1988, 33, 1905, 1 };
            Console.WriteLine("Index nomresini daxil edin:");

            int userInput = int.Parse(Console.ReadLine());

            try
            {
                if (userInput > myArr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Console.WriteLine($"Cixarma ugurlu oldu,index deyeri:{myArr[userInput]}");
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index duzgun daxil edilmedi:" + ex);
            }
            finally
            {
                Console.WriteLine("Element cixarma prosessi bitdi");
            }

            // Bir neçə şəxsin adları və telefon nömrələrini saxlayan bir Dictionary yaradın.
            // İstifadəçidən ad və telefon nömrəsi qəbul edərək telefon kitabçasına əlavə
            // edən və müəyyən bir adı daxil etdikdə telefon nömrəsini tapan bir proqram yazın.

            //Dictionary<string, string> telefonKitabı = new Dictionary<string, string>();

            //while (true)
            //{
            //    Console.WriteLine("1: Shexsin adini ve tel nomresini qeydiyyat ucun daxil edin:");
            //    Console.WriteLine("2: Axtarish etmek ucun telefon nomresini daxil edin");
            //    Console.WriteLine("3: Cixish.");


            //    string secim = Console.ReadLine();

            //    switch (secim)
            //    {
            //        case "1":
            //            Console.WriteLine("Ad daxil edin:");
            //            string ad = Console.ReadLine();
            //            Console.WriteLine("Tel nomresini qeyd edin:");
            //            string telNomre = Console.ReadLine();

            //            telefonKitabı.Add(ad, telNomre);
            //            Console.WriteLine($"{ad} adli insan ve {telNomre} nomre telefon kitabcasina elave edildi!");
            //            break;

            //        case "2":
            //            Console.WriteLine("Axtardiginiz nomreni tapmaq ucun ad qeyd edin:");
            //            string axtarilanAd = Console.ReadLine();
            //            if (telefonKitabı.ContainsKey(axtarilanAd))
            //            {
            //                string tapilanNomre = telefonKitabı[axtarilanAd];
            //                Console.WriteLine($" {axtarilanAd} -in  telefon nomresi: {tapilanNomre}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bu adda kontakt tapilmadi!");
            //            }
            //            break;
            //            case "3":
            //            return;
            //        default:
            //            Console.WriteLine("Yanlish sorgu,yeniden cehd edin");
            //            break;
            //    }
            //}


            // İstifadəçidən iki ədəd alın və onların cəmini hesablayan bir proqram yazın.
            // Əgər istifadəçi ədəd daxil etməzsə və ya yanlış formatda ədəd daxil edərsə,
            // bu səhvi tutub ekrana error mesaj çıxarın. Hər halda, proqramın sonunda "Hesablama bitdi" mesajı çıxmalıdır.

            //try
            //{
            //    Console.WriteLine("Birinci ededi daxil edin:");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ikinci ededi daxil edin:");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 + num2;
            //    Console.WriteLine("Netice:" + result);

            //}
            //catch (System.FormatException)

            //{
            //    throw new FormatException("Yanlish format");
            //}

            //finally
            //{
            //    Console.WriteLine("Hesablama bitdi");
            //}

            //Şirkətdə işləyən şəxslərin e-maillərini saxlamaq üçün bir HashSet yaradın.
            //     E - mail ünvanlarını əlavə edin və hər hansı bir e-mailin siyahıda olub-olmadığını yoxlayan
            //     bir proqram yazın. Əgər e-mail varsa, "Bu e-mail mövcuddur" mesajı göstərilməlidir.

            //HashSet<string> set = new HashSet<string>();
            //set.Add("msbrad@yahoo.com");
            //set.Add("volodin55@gmail.com");
            //set.Add("mustafapektas@gmail.com");
            //set.Add("matrix@yahoo.com");

            //Console.WriteLine("msbrad@yahoo.com".GetHashCode());
            //Console.WriteLine("volodin55@gmail.com".GetHashCode());
            //Console.WriteLine("mustafapektas@gmail.com".GetHashCode());
            //Console.WriteLine("matrix@yahoo.com".GetHashCode());

            //Console.Write("Emailinizi daxil edin:");
            //string email = Console.ReadLine();
            //foreach (var item in set)
            //{
            //    if (set.Contains(email))
            //    {
            //        Console.WriteLine($"Bu e-mail siyahida var --> {email} HashCode--> {email.GetHashCode()}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Bu email siyahida yoxdur");
            //        return;
            //    }
            //}
        }

    }

}















