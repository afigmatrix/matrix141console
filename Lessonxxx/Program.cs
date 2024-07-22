using System;
using System.Collections.Generic;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //Verilmiş arraydan bir elementi çıxaran bir proqram yazın.
            //Əgər istifadəçi array olmayan bir indeks sorğulasa,
            //bu səhvi tutub ekrana mesaj çıxarın. Hər halda,
            //proqramın sonunda "Element çıxarma prosesi bitdi" mesajı çıxmalıdır.
            //Arrayi normal array olaraq yaradin.

            int[] ints = { 1, 12, 9, 7, 3 };

            Console.WriteLine("Element cixarmaq ucun indeks daxil edin:");
            string input = Console.ReadLine();

            try
            {

                int index = int.Parse(input);
                if (index >= 0 && index <= ints.Length - 1)
                {
                    index = ints[index];

                    Console.WriteLine("Index " + (input) + " = " + "Deyer " + (index));
                }




            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Yanlis formatli indeks!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sehf indeks:  {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Element cixarma prosesi bitdi");
            }

            #endregion


            #region Task2

            //İstifadəçidən iki ədəd alın və onların cəmini hesablayan bir proqram yazın.
            //     Əgər istifadəçi ədəd daxil etməzsə və ya yanlış formatda ədəd daxil edərsə,
            //     bu səhvi tutub ekrana error mesaj çıxarın. Hər halda,
            //     proqramın sonunda "Hesablama bitdi" mesajı çıxmalıdır.

            Console.WriteLine("Ededleri daxil edin");

            try
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                if (num1 == num1 && num2 == num2)
                {
                    var result = num1 + num2;
                    Console.WriteLine($"Cavab: {result}");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Yanlis formatli eded daxil etmisiniz!");
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Hesablama bitdi");

            }
            #endregion

            #region  Task3


            //Bir neçə şəxsin adları və telefon nömrələrini saxlayan bir Dictionary yaradın.
            //    İstifadəçidən ad və telefon nömrəsi qəbul edərək
            //  telefon kitabçasına əlavə edən və müəyyən bir adı daxil etdikdə
            //telefon nömrəsini tapan bir proqram yazın.

            //  Dictionary<string, string> istifadə edin.

            Dictionary<string, int> rehber = new Dictionary<string, int>();

            Console.WriteLine("Ad daxil et:");
            var name = Console.ReadLine();
            Console.WriteLine("Nomre daxil et:");
            var num = int.Parse(Console.ReadLine());
            rehber.Add(name, num);
            Console.WriteLine("Mueyyen bir ad daxil et:");
            string Name = Console.ReadLine();
            if (rehber.ContainsKey(Name))
            {
                Console.WriteLine($"{Name}in telefon nomresi:\n{num}");
            }
            else
            {
                Console.WriteLine($"Rehberde bu ad yoxdur:\n{name}");
            }

            #endregion


            #region Tash4


            //Şirkətdə işləyən şəxslərin e-maillərini saxlamaq üçün bir HashSet yaradın.
            //   E - mail ünvanlarını əlavə edin və hər hansı bir e-mailin siyahıda
            //     olub - olmadığını yoxlayan bir proqram yazın. Əgər e-mail varsa,
            //     "Bu e-mail mövcuddur" mesajı göstərilməlidir.

            // HashSet<string> istifadə edin.

            HashSet<string> mail = new HashSet<string>();

            mail.Add("Sefer@mail.com");
            mail.Add("Rza11mail.com");
            mail.Add("Amil@mail.com");
            mail.Add("Ehmed22mail.com");
            mail.Add("Baku/mail.com");
            Console.WriteLine("E-maili daxil edin:");
            string EmailYoxla = Console.ReadLine();

            if (mail.Contains(EmailYoxla))
            {
                Console.WriteLine("Bu e-mail movcuddur:");
            }
            else
            {
                Console.WriteLine("Bu e-mailm movcud deyil.");
            }
            #endregion
        }

    }
}
