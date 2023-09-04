using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    public class StringUtil
    {


        public static void Get(int no)
        {
            Console.WriteLine(no);
        }

        public static void Get(double no)
        {
            Console.WriteLine(no);
        }

        public static void DisplayStart()
        {
            Console.WriteLine("Enter no of rows for start pattern");



            #region Start from center


            ////    *
            ////   ***
            ////  *****
            //// *******
            ////*********

            var noOfRows = Console.ReadLine();

            //int num = int.Parse(noOfRows);
            int rows = Convert.ToInt32(noOfRows);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion


            #region Star pattern
            // *
            // * *
            // * * *

            //for (int i = 0; i < lineNo; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= lineNo; i++)
            //{
            //    for (int j = 0; j <i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion


            //Console.ReadLine();
        }

        #region NullCoalesing
        public static void NullCoalesing_()
        {
            string a = null;
            string b = null;
            string c = null;
            Console.WriteLine("NullCoalesing_ : {0}", a ?? b ?? c);
        }


        public static void NullCoalesing_a()
        {
            string a = "a";
            string b = null;
            string c = null;
            Console.WriteLine("NullCoalesing_a: {0}", a ?? b ?? c);
        }
        public static void NullCoalesing_b()
        {
            string a = null;
            string b = "b";
            string c = null;
            Console.WriteLine("NullCoalesing_b: {0}", a ?? b ?? c);
        }
        public static void NullCoalesing_c()
        {
            string a = null;
            string b = null;
            string c = "c";

            Console.WriteLine("NullCoalesing_c: proper way : {0}", a ?? b ?? c);
            //Console.WriteLine("NullCoalesing_c not proper way to use: " + a ?? b ?? c);
        }
        public static void NullCoalesing_bc()
        {
            string a = null;
            string b = "b";
            string c = "c";
            Console.WriteLine("NullCoalesing_bc: {0}", a ?? b ?? c);
        }
        public static void NullCoalesing_abc()
        {
            //int? item_1 = null;
            //int? item_2 = null;
            //int? item_3 = 500;
            //int? item_4 = item_1 ?? item_2 ?? item_3;

            string item_1 = null, item_2 = null, item_3 = "sdf";
            string item_4 = item_1 ?? item_2 ?? item_3;

            Console.WriteLine("Value of item_4 is: {0} ", item_4);
        }
        #endregion
        public static void SwitchCase()
        {
            
            char ch_a = 'a';
            //char ch_a = 'c';
            
            switch (ch_a)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("case A | case a");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("case B | case b");
                    break;

                case 'C':
                case 'c':
                case 'D':
                case 'd':
                    Console.WriteLine("case c C | case d D");
                    break;
            }
        }
    }
}
