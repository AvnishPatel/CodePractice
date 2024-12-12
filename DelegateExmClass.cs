using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public class Course_DeleteDemo
    {
        // Declare a delegate.
        public delegate void GreetCallback();

        // Declare a delegate.
        public delegate int CalculationCallback(int x, int y);

        public static void SampleMethod()
        {
            #region Declare a method with the same signature as the delegate - GreetCallback
            // Delegate without argument and retutn type

            // Single Delegate
            GreetCallback del = DelegateExmClass.DisplayDetail;
            del();

            // Multicast Delegate
            del += DelegateExmClass.ShowDetail;
            del();

            DelegateExmClass obj = new DelegateExmClass();
            GreetCallback d2 = obj.PrintDetail;  // its a non static method so need to initialize object
            d2();
            #endregion


            #region #region Declare a method with the same signature as the delegate - CalculationCallback

            // Create an instance of the delegate.
            CalculationCallback del2 = new CalculationCallback(DelegateExmClass.Substrsction);
            del2(5, 2);


            // or another way to Create an instance of the delegate.
            CalculationCallback del_cal = DelegateExmClass.Addition;

            del_cal += DelegateExmClass.Multiplication;
            
            del_cal(4, 2); // will call Addition() and Multiplication() methods with same param
            #endregion

        }
    }

    public class DelegateExmClass
    {
        #region Methods : No Arguments No Return type
        public static void DisplayDetail()
        {
            Console.WriteLine("Hello from Display");
        }

        public static void ShowDetail()
        {
            Console.WriteLine("Hello from Show");
        }

        public void PrintDetail()
        {
            Console.WriteLine("Print");
        }
        #endregion


        #region Methods :  Arguments and Return type
        public static int Addition(int number1, int number2)
        {
            int res = number1 + number2;
            Console.WriteLine("Addition : " + res);
            return res;
        }
        public static int Multiplication(int number1, int number2)
        {
            int res = number1 * number2;
            Console.WriteLine("Multiplication : " + res);
            return res;
        }
        public static int Substrsction(int number1, int number2)
        {
            int res = number1 - number2;
            Console.WriteLine("Substrsction : " + res);
            return res;
        }

        #endregion
    }
}
