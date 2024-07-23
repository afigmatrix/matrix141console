using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Lessonxxx
{
    internal class Program
    {
        public delegate void CalculatorHandler(int num1, int num2);
        static void Main(string[] args)
        {
            #region Predicate
            //List<int> myInt = new List<int> { 4, 3, 2, 2, 4, 35, 2 };
            //var even = myInt.Where(m => m % 2 == 0).ToList();
            //var odd = myInt.Where(m => m % 2 == 1).ToList();
            //var res = myInt.Where(MyPredicate).ToList();

            #endregion
            #region Action-Func
            //Func<int, int, int> myMethod = Sum;
            //myMethod = Divide;
            //Console.WriteLine(Calculate(Sum, 4, 6, 10));
            #endregion
            #region delegate
            //CalculatorHandler cHandler = new CalculatorHandler(Sum);
            //cHandler += Divide;
            //cHandler += Multip;
            //cHandler += Minus;
            //cHandler(5, 2); 
            #endregion
            #region Event
            //ATM kapitalATM = new ATM();
            //kapitalATM.OperationSuccessEvent += KapitalATM_SendCentralBank;
            //kapitalATM.OperationSuccessEvent += KapitalATM_LocalBranch;
            ////       kapitalATM.OperationFailEvent -= KapitalATM_OperationFailEvent;
            //kapitalATM.OperationSuccessEvent += delegate (string fincode)
            //{
            //    Console.WriteLine("User notificatin invoke");
            //    return 8;
            //};

            //kapitalATM.OperationSuccessEvent += (string fincode) =>
            //{
            //    Console.WriteLine("sad");
            //    return 9;
            //};

            //// =>Lambda Expression
            //kapitalATM.Cash(5000);
            #endregion
        }

        private static bool MyPredicate(int m)
        {
            return m > 3;
        }



        private static int KapitalATM_OperationFailEvent(string fincode)
        {
            throw new NotImplementedException();
        }

        public static int KapitalATM_LocalBranch(string fincode)
        {
            Console.WriteLine("Sended Local Branch");
            return 8;
        }

        private static int KapitalATM_SendCentralBank(string fincode)
        {
            Console.WriteLine("Sended Central Branch");
            return 8;
        }

        static void Sum(int num1, int num2)
        {
            var res = num1 + num2;
            Console.WriteLine(res);
        }
        static void Divide(int num1, int num2)
        {
            var res = num1 / num2;
            Console.WriteLine(res);
        }

        static void Multip(int num1, int num2)
        {
            var res = num1 * num2;
            Console.WriteLine(res);
        }

        static void Minus(int num1, int num2)
        {
            var res = num1 - num2;
            Console.WriteLine(res);
        }

        static int Calculate(Func<int, int, int> method, int num1, int num2, int sum)
        {
            var methodRes = method(num1, num2);
            return methodRes + sum;
        }
    }


    public class ATM
    {
        public delegate int OperationHandler(string fincode);
        public event OperationHandler OperationSuccessEvent;

        public delegate int OperationFailHandler(string fincode);
        public event OperationFailHandler OperationFailEvent;

        public int Balans = 1000;

        public void Cash(int userCashCount)
        {
            if (Balans < userCashCount)
            {
                OperationFailEvent?.Invoke("askhjdgsa");
            }
            else
            {
                OperationSuccessEvent("5js0000");
            }
        }
    }
}
