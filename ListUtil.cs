using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    public class ListUtil
    {
        public static void CheckElementInList()
        {
            List<int> firstList = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                firstList.Add(i);
            }

            Console.WriteLine(firstList.Exists(isEven));

        }


        private static bool isEven(int i)
        {
            Console.WriteLine("------------");
            Console.WriteLine(i + " : ");
            Console.WriteLine(i % 2);
            return i % 2 == 0;
        }


        public static void CalAvg(int a1)
        {
            
            Console.WriteLine(a1);
        }

        public static int CalAvg(int? b1)
        {

            Console.WriteLine(b1);
            return 1;
        }
    }
}

