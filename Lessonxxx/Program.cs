using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iphone iphone = new Iphone("JBL");
            //Iphone iphone2 = new Iphone();
            //Console.WriteLine(iphone.Camera);

            Task2();
        }

        static void Task2()
        {
            Console.WriteLine("Please,enter value");
            string userInput = Console.ReadLine();
            char[] letters = new char[userInput.Length];
            int[] counts = new int[userInput.Length];
            int letterIndex = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                char letter = userInput[i];
                if (letters[0] == default(char))
                {
                    letterIndex = SetDefault(letters, counts, letterIndex, letter);
                    continue;
                }

                int checkResult = LetterIsExist(userInput[i], letters);
                if (checkResult != -1)
                {
                    counts[checkResult]++;
                }
                else
                {
                    AddNewLetter(letters, counts, ref letterIndex, letter);
                }
            }
            Print(letters, counts);
        }

        private static int SetDefault(char[] letters, int[] counts, int letterIndex, char letter)
        {
            letters[0] = letter;
            counts[0]++;
            letterIndex++;
            return letterIndex;
        }

        static void Print(char[] letters, int[] counts) {
            for (int i = 0; i < letters.Length; i++)
            {
                int count = counts[i];
                if (count == 0) break;
                char letter = letters[i];
                Console.WriteLine($"{letter}  => {count} defe istifade olunub");
            }
        }

         static void AddNewLetter(char[] letters, int[] counts, ref int letterIndex, char letter)
        {
            letters[letterIndex] = letter;
            counts[letterIndex]++;
            letterIndex++;
        }

        static int LetterIsExist(char letter, char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == letter)
                {
                    return i;
                }
            }
            return -1;
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
