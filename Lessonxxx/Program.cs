using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region try-catch-finally
            //Console.WriteLine("Hello World!");
            //int num1 = 8;
            //int zero = 0;
            //string name = null;
            //try
            //{
            //    var res = num1 / zero;
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Aritmetic ex");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.GetType());
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region ArrayList
            //int[] studentNumberList = new int[4];
            //ArrayList arrlist = new ArrayList(6);
            //Console.WriteLine(arrlist.Capacity);
            //arrlist.Add("Hesen");
            //arrlist.Add(89);
            //Console.WriteLine(arrlist.Capacity);
            //arrlist.Remove(89);
            //arrlist.Add(89);
            //arrlist.Add(89);
            //Console.WriteLine(arrlist.Capacity);
            //arrlist.TrimToSize();
            //Console.WriteLine(arrlist.Capacity);

            #endregion
            #region Stack
            //Stack bookStack = new Stack();
            //bookStack.Push("Komp1");
            //bookStack.Push("Komp2");
            //bookStack.Push("Komp3");
            //bookStack.Push("Komp4");

            //Console.WriteLine(bookStack.Peek());
            //Console.WriteLine(bookStack.Peek());
            #endregion
            #region Queue
            //Queue queue = new Queue();
            //queue.Enqueue("Komp1");
            //queue.Enqueue("Komp2");
            //queue.Enqueue("Komp3");
            //queue.Enqueue("Komp4");
            //Console.WriteLine(queue.Dequeue());
            #endregion
            #region List
            //List<int> intArr = new List<int>();
            //intArr.Add(3);
            //intArr.Add(3);
            //intArr.Remove(3);
            #endregion
            #region Dictionary
            //Dictionary<int, char> myCharList = new Dictionary<int, char>();
            //myCharList.Add((int)'a', 'a');
            //myCharList.Add((int)'b', 'b');
            //myCharList.Add((int)'c', 'c');

            //foreach (KeyValuePair<int, char> item in myCharList)
            //{
            //    Console.WriteLine($"key : {item.Key} => value : {item.Value}");
            //}
            #endregion
            #region HashSet
            HashSet<string> strings = new HashSet<string>();
            strings.Add("matrix");
            strings.Add("Matrix");
            strings.Add("matrix");

            List<string> users = new List<string>();
            users.Add("matrix");
            users.Add("Matrix");
            users.Add("matrix");

            #endregion
        }
    }
}
