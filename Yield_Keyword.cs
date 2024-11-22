using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodePractice
{
    public class Yield_Keyword
    {
        // https://www.youtube.com/watch?v=eP8ybqafmz0&ab_channel=InterviewHappy
        #region Without Yield : Part 1
        public static IEnumerable<int> GetEvenNumbers(int upto)
        {

            List<int> list = new List<int>();
            for (int i = 0; i <= upto; i += 2)
            {
                list.Add(i);
                Console.WriteLine("Print");
            }
            return list;
        }

        public static void DisplayEvenNumber_WithoutYield()
        {
            IEnumerable<int> evenNumbers = GetEvenNumbers(10);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region With Yield : Part 2

        public static void DisplayEvenNumber_WithYield()
        {
            Console.WriteLine("Execution start: 0");
            IEnumerable<int> evenNumbers = GetEvenNumbers_ByYield(10);
            Console.WriteLine("Execution start: 1");

            foreach (var item in evenNumbers) // GetEvenNumbers_ByYield execute here
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> GetEvenNumbers_ByYield(int upto)
        {
            //List<int> list = new List<int>();
            for (int i = 0; i <= upto; i += 2)
            {
                Console.WriteLine("Print before yield");
                //list.Add(i);
                yield return i;
                Console.WriteLine("Print after yield");
                Console.WriteLine("--------------------");
            }
            //return list;
        }
        #endregion

        #region Yield demo
        public static void DisplayNumber()
        {
            foreach (var item in Inetegers())
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> Inetegers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        #endregion


        #region Yield with Break
        public static void Yield_Break()
        {
            int[] intArray = [1, 2, -3, 4];
            Console.WriteLine(string.Join(",", TakeUptoPositiveValue(intArray)));
        }

        public static IEnumerable<int> TakeUptoPositiveValue(int[] numbers)
        {
            foreach (var num in numbers)
            {
                if (num > 0)
                    yield return num;
                else
                    yield break;
            }
        }
        #endregion
        
        #region Cannot modify IEnumerable
        public static void IEnumerableCannotModify()
        {

            IEnumerable<int> numbersIEnumerable = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("IEnumerable: ");
            foreach (int num in numbersIEnumerable)
            {
                Console.WriteLine(num);
            }

            //numbersIEnumerable.Add(6);
        }

        #endregion
    }
}
