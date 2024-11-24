using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public static class TempClass
    {
        #region Get Factorial of Number
        public static void FactorialNumber(int _number)
        {
            if (_number == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(GetFactorialByRecusrsion(_number));
        }

        private static int GetFactorialByRecusrsion(int _number)
        {
            if (_number == 1)
                return 1;
            else
                return _number * GetFactorialByRecusrsion(_number - 1);
        }
        #endregion

        #region Is Palindrom String
        public static void IsPalindromString(string _inputStr)
        {
            if (string.IsNullOrWhiteSpace(_inputStr))
                Console.WriteLine("Please provide valid string");
            else
            {
                Console.WriteLine("Input String : " + _inputStr);
                bool isPal = true;
                int left = 0;
                int right = _inputStr.Length - 1;

                for (int i = 0; i < _inputStr.Length; i++)
                {
                    if (left <= right)
                    {
                        if (_inputStr[left] == _inputStr[right])
                        {
                            left++;
                            right--;
                        }
                        else
                        {
                            isPal = false;
                            break;
                        }
                    }
                }
                Console.WriteLine("Pallindrom string : {0}", isPal);
            }
        } 
        #endregion

        #region Get Fibonacci Number/Series
        public static void GetFibonacciString(int _number)
        {
            // i/p _number = 8
            // 0, 1, 1, 2, 3, 5, 8, 13
            // op : 13
            Console.WriteLine("Fib Number for {0} is {1}", _number, GetFibonacciByRecursion(_number));
        }

        private static int GetFibonacciByRecursion(int _number)
        {
            if (_number == 1)
                return 0;
            else if (_number == 2)
                return 1;
            else
                return GetFibonacciByRecursion(_number - 1) + GetFibonacciByRecursion(_number - 2);
        }
        #endregion

        #region Get Unique Char From String
        public static void GetNonRepeatedCharFromString(string _inputStr)
        {
            Console.WriteLine("Input is : {0}", _inputStr);
            _inputStr = _inputStr.Replace(" ", "");
            char[] charAry = _inputStr.ToCharArray();
            List<char> charList = new List<char>();

            for (int i = 0; i < charAry.Length; i++)
            {
                int repeatcount = 0;
                for (int j = 0; j < charAry.Length; j++)
                {
                    if (charAry[i] == charAry[j])
                        repeatcount++;
                }

                if (repeatcount == 1)
                    charList.Add(charAry[i]);
            }

            Console.WriteLine("Non Repeated char are : {0}", new string(charList.ToArray()));
        }

        public static void Get1stUniqueCharFromString(string _inputStr)
        {
            // Input : avnish Patel
            // output: vnishPtl
            Console.WriteLine("Input is : {0}", _inputStr);
            _inputStr = _inputStr.Replace(" ", "");
            char[] charAry = _inputStr.ToCharArray();

            for (int i = 0; i < charAry.Length; i++)
            {
                int repeatcount = 0;
                for (int j = 0; j < charAry.Length; j++)
                {
                    if (charAry[i] == charAry[j])
                        repeatcount++;
                }

                if (repeatcount == 1)
                {
                    Console.WriteLine("1st unique char is : {0}",
                        new string(charAry[i].ToString()));
                    return;
                }
            }
        }
        #endregion


        #region Reverse string
        public static string ReverseOfString(string _input)
        {
            // input : abc   // output: cba

            Console.WriteLine("Input string : {0}", _input);

            if (string.IsNullOrWhiteSpace(_input))
                return null;

            char[] charAry = _input.ToCharArray();
            char[] reversecharAry = new char[charAry.Length];

            string reverseStr = ""; // method 2

            int j = 0;
            for (int i = charAry.Length - 1; i >= 0; i--)
            {
                reversecharAry[j] = charAry[i];
                j++;

                // or
                reverseStr = reverseStr + charAry[i]; // method 2
            }

            Console.WriteLine("Reverse string method 1 : {0}", new string(reversecharAry));
            Console.WriteLine("Reverse string method 2: {0}", reverseStr);

            return new string(reversecharAry);
        }
        public static void ReverseOfWordFromStatement(string _input)
        {
            // input : Hello World   // output: World Hello

            Console.WriteLine("Input string : {0}", _input);

            if (string.IsNullOrWhiteSpace(_input))
                return;

            var list = _input.Split(" ");
            List<string> reverseList = new List<string>();

            for (int i = list.Length - 1; i >= 0; i--)
            {
                reverseList.Add(list[i]);
            }

            Console.WriteLine("Reverse string : {0}", string.Join(" ", reverseList));
        }
        #endregion

        #region Reverse Number
        public static int ReverseNumber(int _number)
        {
            // ip : 123
            // op : 321
            if (_number < 10)
                return _number;
            else
            {
                int _result = 0;

                while (_number > 0)
                {
                    int _reminder = _number % 10;

                    _result = _result * 10 + _reminder;
                    _number = _number / 10;
                }
                return _result;
            }
        }
        #endregion


        #region Largest Number, nth Largset Number (with index)
        public static void LargestNumberWithIndexFromArray(int[] unsortedAry)
        {
            // ip : [40, 70, 20, 10, 60, 30, 50]
            int largestNo = unsortedAry.ToList().Max();

            Console.WriteLine("Largest number : {0}, and index is {1}",
                largestNo, Array.IndexOf(unsortedAry, largestNo));
        }
        public static void nthLargestNumberFromArray(int n)
        {
            int[] unsortedAry = [70, 20, 40, 10, 60, 30, 50];

            if (n > unsortedAry.Length)
            {
                Console.WriteLine("Warning: Number {0} is > Array size {1}", n, unsortedAry.Length);
                return;
            }

            unsortedAry = unsortedAry.OrderByDescending(x => x).ToArray();

            Console.WriteLine("{0} th largest number : {1}", n, unsortedAry[n - 1]);

            foreach (var item in unsortedAry)
                Console.Write(item + " ,");
        }
        #endregion

        #region  Duplicate value from array (Remove/ Get/ ignore)
        public static void RemoveDuplicateValueFromArray()
        {
            int[] anArray = { 1, 5, 2, 7, 6, 7, 3, 6 };

            var uniqueList = anArray
                .GroupBy(i => i)
                .Where(g => g.Count() == 1)  // logic
                .Select(g => g.Key);

            Console.Write("The uniqueList : ");

            foreach (var d in uniqueList)
                Console.Write(d + ", ");

            Console.WriteLine();
        }
        public static void ListDuplicateValueFromArray()
        {
            int[] anArray = { 1, 5, 2, 7, 6, 7, 3, 6 };

            var duplicateList = anArray
                .GroupBy(i => i)
                .Where(g => g.Count() > 1) // logic
                .Select(g => g.Key);

            Console.Write("The duplicate are : ");

            foreach (var d in duplicateList)
                Console.Write(d + ", ");
        }

        public static void RemoveDuplicateValueButContainAtLeatOnceFromArray()
        {
            // ip : { 1, 1, 5, 2, 7, 6, 7, 3, 6 };
            // op : { 1, 5, 2, 7, 6 , 3}  // Repeated later comes atleast once

            int[] anArray = { 1, 1, 5, 2, 7, 6, 7, 3, 6 };
            List<int> uniqueList = new List<int>();

            //int[] uniqueAry = new int[anArray.Length-1];  
            // Never use array to hold unique value, otherwise it will create same same of array as input array size
            // but unique array value may be less than input array by removing duplicate value


            for (int i = 0; i < anArray.Length - 1; i++)
            {
                var _index = uniqueList.IndexOf(anArray[i]);  // if not exist, then return : -1
                if (_index < 0)
                    uniqueList.Add(anArray[i]);
            }

            Console.Write("The uniqueList : ");
            foreach (var d in uniqueList)
                Console.Write(d + ", ");
        }


        // Remove Duplicate Value from Array But don't Use new Array
        public static void RemoveDuplicateValueButNotUsenewArray()
        {
            // ip : { 1, 1, 5, 2, 7, 6, 7, 3, 6 };
            // op : { 1, 5, 2, 7, 6 , 3}  // Repeated later comes atleast once

            int[] anArray = { 1, 1, 5, 2, 7, 6, 7, 3, 6 };

            int ci = 1;
            for (int i = 1; i < anArray.Length; i++)
            {
                if (anArray[ci-1] != anArray[i])  // 1st number "anArray[ci]" & 2nd No "anArray[i]" is not same then
                    anArray[ci++]= anArray[i];  // increase index of [ci], and index of "i" will increasw as loop iterate
            }

            Console.Write("The uniqueList : ");
            foreach (var d in anArray.Take(ci)) // .Take(ci) : return array upto size of ci
                Console.Write(d + ", ");
        }
        #endregion


        public static void BracketPair(string bracketValue)
        {
            if (string.IsNullOrWhiteSpace(bracketValue))
                return;

            //bracketValue = "{[()]}";          //op: Valid
            //string bracketValue = "{[}()]";   //op: Invalid
            //string bracketValue = "{[)(]}";   //op: Invalid
            bool isValidPair = CheckBracketPair(bracketValue);
            Console.WriteLine("{0} is Valid bracket ? : {1}", bracketValue, isValidPair);
        }

        private static bool CheckBracketPair(string _bracket)
        {
            Stack<char> pairStack = new Stack<char>();
            foreach (char pair in _bracket)
            {
                if(IsOpeningPair(pair))
                    pairStack.Push(pair);
                else if(pairStack.Count != 0)
                {
                    if (GetClosingPair(pairStack.Peek()) == pair)
                    {
                        pairStack.Pop();
                    }
                }
            }

            if (pairStack.Count == 0)
                return true;
            else
                return false;
        }

        private static bool IsOpeningPair(char pair)
        {
            switch (pair)
            {
                case '{':
                case '(':
                case '[':
                    return true;
                default:
                    return false;
            }
        }
        private static char GetClosingPair(char pair)
        {
            switch (pair)
            {
                case '(':
                    return ')';
                case '{':
                    return '}';
                case '[':
                    return ']';
                default:
                    return default(char);
            }
        }

    }
}