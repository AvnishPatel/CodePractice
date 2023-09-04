using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    // this keyword is used to refere to the current instance of the class.
    // it is used to access member from the constructor, instance methos 
    public class ThisKeyword
    {
        
        public ThisKeyword() : this("geeks")
        {
            Console.WriteLine("Non Param constructor");
        }

        public ThisKeyword(string name)
        {
            Console.WriteLine("Parameter Constructor Called");
        }


        #region Using ‘this’ keyword to invoke current class method 
        void display()
        {
            // calling function show()
            this.show();

            Console.WriteLine("Inside display function");
        }

        void show()
        {
            Console.WriteLine("Inside show function");
        }

        #endregion

    }

    internal class show
    {
    }
}
