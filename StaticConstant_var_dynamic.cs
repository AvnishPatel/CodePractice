using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    public static class StaticConstant_var_dynamic
    {
        // Can we change static value ? 
        // Yes
        public static string name = "Avnish";

        public static void ChangeStaticValue()
        {
            name = "Avnish Patel";
            
            Console.WriteLine("Name : {0} ", name);

            #region var vs Dynamic
            var var_value = 10; // statement 1 
            //var_value = "GeeksforGeeks"; // statement 2 : NOTE : if you uncomment, gives error
            // var initial datatype is int,
            // later on if you try to assign different data type value then gives erro
            
            dynamic dynamic_value = 10; // statement 1 
            dynamic_value = "GeeksforGeeks"; // statement 2 
            // Note : initial dynamic_value data type is int
            // but we can assign different data type value like string value
            // Now dynamic_value have new datatype string.
            // this is not possible with "var"
            #endregion

        }

        #region Const

        //  If we not initialise const value then it cause error
        //public const float PI;

        public const float PI = 3.14f;


        public static void CheckConstatValue()
        {
            // if you try to change const value then it cause error
            //PI = 4.4;
            Console.WriteLine("PI : {0} ", PI);
        }

        #endregion
    }

    public  class ReadOnlyCls
    {
        
        readonly int z; //Readonly Variable
        
        //Constructor
        public ReadOnlyCls(int b)
        {
            //Initializing Readonly variable
            z = b;

            // you can change multiple times value of readonly in condtructor
            //z = 12;
        }
        public static void GetReadOnly()
        {

            //Creating two instances
            ReadOnlyCls obj1 = new ReadOnlyCls(300);
            ReadOnlyCls obj2 = new ReadOnlyCls(400);
        
            //Accessing Non-Static and Readonly variables using instance
            Console.WriteLine($"obj1 Readonly z value: {obj1.z}");
            Console.WriteLine($"obj2 Readonly z value: {obj2.z}");
            Console.Read();
        }
    }
}
