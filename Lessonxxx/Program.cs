using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 18;
            Financial financial = new Financial();
            financial.SetAge(17);
            financial.PropAge = 18;
            Console.WriteLine(financial.GetAge());
            Console.WriteLine(financial.PropAge);
        }
    }

    public class Financial
    {
        private int _age; //18 < 
        public int PropAge { get { return _age; } set { _age = value; } }
        public int GetAge()
        {
            if (DateTime.Now.Day == 5 )
            {
                return _age;
            }
            return -1;

        }

        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
