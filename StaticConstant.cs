using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    public static class StaticConstant
    {
        // Can we change static value ? 
        // Yes
        public static string name = "Avnish";

        public static void ChangeStaticValue()
        {
            name = "Avnish Patel";
            
            Console.WriteLine("Name : {0} ", name);

            #region var vs Dynamic
            var myvalue = 10; // statement 1 
            //myvalue = "GeeksforGeeks"; // statement 2
                                       //
            dynamic val = 10; // statement 1 
            val = "GeeksforGeeks"; // statement 2 
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
