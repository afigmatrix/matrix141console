using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("JBL");
            Iphone iphone2 = new Iphone();
            Console.WriteLine(iphone.Camera);
        }


    }
    public class Iphone : Phone
    {
        public string Camera;
        public string MacroCamera;

        public Iphone(string camera)
        {
            Camera = camera;
        }

        public Iphone()
        {
            
        }

    }







    public class Phone
    {
        public string Marka;
        public string Model;
        public string Color;
        public int BataryCapasity;
        public bool StudentCount;

        public void Call()
        {
            Console.WriteLine("Phone call");
        }
    }

 

    public class Ericson : Phone
    {
        public string Lid;
    }

    public class Monaliza
    {
        public string Name;
        public int Wight;
    }



}
