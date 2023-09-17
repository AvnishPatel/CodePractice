using System;

namespace CodePractice
{
    public static class Ref_Vs_Out
    {
        // 1 : must need to initialise before use as ref in method param
        // 2 : The out parameter ‘Subtraction’ must be assigned, before control leaves the current method
        public static void RefMethod()
        {
            //First Declare the Variables
            int Addition = 0;
            int Multiplication = 0; // must need to initialise before use as ref in method param
            int Subtraction=0; // if you will not assign then also it works fine. out not required initialisation before use as show for Division
            int Division;

            //While calling the Method, decorate the ref keyword for ref arguments
            //Addition, Multiplication, Subtraction, and Division variables values will be updated by Math Function
            Math(200, 100, ref Addition, ref Multiplication, out Subtraction, out Division);

            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Division: {Division}");
        }

        //Declaring Method with Ref Parameters
        public static void Math(int number1, int number2, ref int Addition,
            ref int Multiplication, out int Subtraction, out int Division)
        {

            Addition = number1 + number2;       // This will Update the Addition variable Declared in Main Method

            Multiplication = number1 * number2; // This will Update the Multiplication variable Declared in Main Method

            Subtraction = number1 - number2;    // This will Update the Subtraction variable Declared in Main Method

            Division = number1 / number2;       // This will Update the Division variable Declared in Main Method
        }


        // will not give error bcz ref param not required to assigned, before control leaves the current method
        public static void RefMath(int number1, ref int Subtraction)
        {
            Console.WriteLine(number1);
            // for 'ref' :  updating/ assigning the value inside the method is optional.
        }



        #region 2 :  Will throw ERROR, The out parameter ‘Subtraction’ must be assigned, before control leaves the current method
        //public static void OutMath(int number1, out int Subtraction)
        //{
        //    Console.WriteLine(number1);
        //    // for 'out' :  updating/ assigning the value inside the method is mandatory.

        //    // must uncomment bellow to work properly
        //    // Subtraction = Subtraction - 2;
        //} 
        #endregion
    }
}
