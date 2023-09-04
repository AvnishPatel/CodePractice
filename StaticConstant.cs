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
    
    }
}
