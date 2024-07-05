using System;
using System.Globalization;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Bird bird = new Bird();
            //bird.weight = 4;
            //bird.isWild = false;
            //bird.Eyecolor = "blue";
            //bird.Height = 25;

            //Lion lion = new Lion();
            //lion.isWild = true;
            //lion.Eyecolor = "green";
            //lion.weight = 100;
            //lion.Height = 70;

            #endregion
            #region task2
            bmw bmw = new bmw("restyling");
            bmw.isModified = true;
            #endregion

        }
    }
    public class Animal
    {
        public int weight;
        public int Height;
        public string Eyecolor;
        public bool isWild;
        public void Run()
        {

        }
    }
    public class Bird : Animal
    {
        public void AbilityToFly()
        {

        }
    }
    public class Lion : Animal
    {
        public void Jump()
        {

        }
    }
    public class car
    {
        public bool isSport;
        public string color;
        public int DoorCount;
        public void start()
        {

        }
        public void stop()
        {

        }
    }
    public class bmw : car
    {
        public bool isModified;
        public string Modificationname;
        public bmw(string modificationname)
        {
            Modificationname = modificationname;
        }
          
    }     
}
