using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessonxxx
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name)
        {
            Name = name;
            Console.WriteLine("Constructor call!" + name);
        }


        public void Test()
        {

        }

        ~Student()
        {
            Console.WriteLine("Destructor call!" + Name);
        }
    }
}
