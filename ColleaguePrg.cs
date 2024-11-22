using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public class ColleaguePrg
    {
        public static void GetFibonacciSerice()
        {
            Console.WriteLine();
            Console.Write("Enter number for Fibobacci Serice : ");
            string strNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(strNo))
                return;

            if (int.TryParse(strNo, out int number))
            {
                if (number < 1)
                {
                    Console.WriteLine("Please provide positive number");
                    return;
                }
                else if (number == 1)
                {
                    Console.Write(0);
                    return;
                }
                else if (number == 2)
                {
                    Console.Write("0, 1");
                    return;
                }
                else
                {
                    Console.Write("0, 1");
                    int x = 0;
                    int y = 1;
                    int z = 0;

                    // iteration start with 2 bcz for 1st iteration : print 0, 2nd iteration print 1
                    for (int i = 2; i < number; i++)
                    {
                        z = x + y;
                        x = y;
                        y = z;

                        Console.Write(", {0}", z);
                    }
                }
            }
        }




        public static void DisplayFibonacciNumberByRecursion()
        {
            Console.WriteLine();
            Console.Write("Enter number for Fibobacci Serice : ");
            string strNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(strNo))
                return;

            if (int.TryParse(strNo, out int number))
            {
                Console.WriteLine(GetFibonacciNumberByRecursion(number));
            }
        }

        private static int GetFibonacciNumberByRecursion(int number)
        {

            if (number == 1)
            {
                return 0;
            }
            else if (number == 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacciNumberByRecursion(number - 1) + GetFibonacciNumberByRecursion(number - 2);
            }
        }
    }

}

