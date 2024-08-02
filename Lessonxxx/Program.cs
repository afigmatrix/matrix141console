using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.Write("soz daxil edin:");
            //string Word=Console.ReadLine();
            //if(string.IsNullOrWhiteSpace(Word))
            //{
            //    Console.WriteLine("duzgun string deyer daxil edin:");
            //    return;
            //}
            //try
            //{
            //    string ReturninString = await RetAsyncMethod(Word);
            //    Console.WriteLine(ReturninString);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //}
            #endregion
            #region task2
            //Console.Write("1-ci reqemi daxil edin:");
            //string GetStringNum1=Console.ReadLine();
            //int IntNum1;
            //int.TryParse(GetStringNum1, out IntNum1);
            //Console.Write("2-ci reqemi daxil edin:");
            //string GetStringNum2=Console.ReadLine();
            //int IntNum2;
            //int.TryParse(GetStringNum2 , out IntNum2);
            //int ReturningCalcResult=await AsyncCalcMethod(IntNum1, IntNum2);
            //Console.WriteLine(ReturningCalcResult);
            #endregion
            #region task3
            //Task[] workers = new Task[10];
            //for (int i = 0; i < 5; i++)
            //{
            //    workers[i] = Task.Run(() =>
            //    {
            //        Singleton instance = Singleton.GetInstanceMethod();
            //        //burda niye iki yazi ekrana cixir?
            //    });
            //}
            //Singleton instance1 = Singleton.GetInstanceMethod();
            //Singleton instance2 = Singleton.GetInstanceMethod();
            //Console.WriteLine(Object.ReferenceEquals(instance1, instance2));
            #endregion
            #region task4
            //Console.Write("her hansi bir reqem daxil edin:");
            //string StringDayNumber=Console.ReadLine();
            //int IntDayNumber;
            //int.TryParse(StringDayNumber, out IntDayNumber);
            //string ReturningDayName=await GetWeekDayName(IntDayNumber);
            //Console.WriteLine($"gunun adi:{ReturningDayName}");
            #endregion
        }
        #region task1
        //public static async Task<string> RetAsyncMethod(string parametr)
        //{
        //   return await Task.FromResult(parametr);
        //}
        #endregion
        #region task2
        //public static async Task<int> AsyncCalcMethod(int num1,int num2)
        //{
        //    int Sum=num1 + num2;
        //     await Task.Delay(2000);
        //    return Sum;
        //}
        #endregion
        #region task3
        //public class Singleton
        //{
        //    private static Singleton instance = null;
        //    private static readonly object _lock = new object();
        //    private string AnyText;
        //    private Singleton()
        //    {
        //        AnyText = "any word";
        //    }
        //    public static Singleton GetInstanceMethod()
        //    {
        //        if (instance == null)
        //        {
        //            lock (_lock)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new Singleton();
        //                    Console.WriteLine("new instance created");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("exist instance used");
        //        }
        //        return instance;
        //    }
        //    public string GetAnyText()
        //    {
        //        return AnyText;
        //    }
        //}
        #endregion
        #region task4
        //public static async Task<string> GetWeekDayName(int DayNumber)
        //{
        //    if (Enum.IsDefined(typeof(Week),DayNumber))
        //    {
        //        Week week = (Week)DayNumber;
        //        return await Task.FromResult(week.ToString());
        //    }
        //    else
        //    {
        //        return "Invalid day number";
        //    }
        //}
        #endregion
    }
    #region task4
    //public enum Week
    //{
    //    monday=1,
    //    tuesday,
    //    wednesday,
    //    thursday,
    //    friday,
    //    saturday,
    //    sunday
    //}
    #endregion
}
