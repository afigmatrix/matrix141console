using System;
using System.Threading.Tasks;

namespace Lessonxxx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string result = await GetParameter("salam");
            //Console.WriteLine(result);


            //int res = await AsyncMethod(5, 10);
            //Console.WriteLine(res);


            //string dayname = await AsyncMethod2(5);
            //Console.WriteLine(dayname);
        }
        public static async Task<string> GetParameter(string name)
        {
            return await Task.FromResult(name);
        }
        public static async Task<int> AsyncMethod(int num1, int num2)
        {
            return await Task.FromResult(num1+num2);
        }
        enum Days
        {
          Monday=1,
          Tuesday,
          Wednesday,
          Thursday,
          Friday,
          Saturday,
          Sunday
        }
        public static async Task<string> AsyncMethod2(int date)
        {
            string dayname = Enum.GetName(typeof(Days), date);
            return await Task.FromResult(dayname);
        }
    }
}
