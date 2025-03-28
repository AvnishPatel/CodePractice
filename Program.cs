using System;
using System.Linq;

namespace CodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Utility function
            //StringUtil.DisplayStart();
            //StringUtil.Get(1);
            //StringUtil.Get(1.0);
            //StringUtil.NullCoalesing_();
            //StringUtil.NullCoalesing_a();
            //StringUtil.NullCoalesing_b();
            //StringUtil.NullCoalesing_c();
            //StringUtil.NullCoalesing_bc();
            //StringUtil.NullCoalesing_abc();
            //StringUtil.SwitchCase(); 
            #endregion

            #region Executionm order of Static and non-static constructor
            //ChildClass childClass = new ChildClass(); 
            #endregion


            #region Static/ Constant /ReadPnly

            //StaticConstant_var_dynamic.ChangeStaticValue();
            //StaticConstant_var_dynamic.CheckConstatValue();

            //ReadOnlyCls.GetReadOnly();

            #endregion

            #region this / ref vs out / List
            //ThisKeyword thisKeyword = new ThisKeyword();

            //Ref_Vs_Out.RefMethod();  

            //ListUtil.CheckElementInList();
            #endregion


            #region Dictionary with ForEach
            //Dictionary_ForEach.DisplayAge();
            //Dictionary_ForEach.DisplayDesignationWithExperience();
            #endregion

            #region Yield and IEnumeration
            //Yield_Keyword.DisplayEvenNumber_WithoutYield();
            //Yield_Keyword.DisplayEvenNumber_WithYield();
            //Yield_Keyword.DisplayNumber();
            //Yield_Keyword.Yield_Break();
            //Yield_Keyword.IEnumerableCannotModify(); 
            #endregion


            #region Is Palindrom String
            //ColleaguePrg.IsPalindromString("AbA");
            //ColleaguePrg.IsPalindromString("AbcbA");
            //ColleaguePrg.IsPalindromString("AbccbA");
            //ColleaguePrg.IsPalindromString("AbcbA");
            //ColleaguePrg.IsPalindromString("AbcbA1"); 
            #endregion

            #region GetFibonacci Number : All  

            //ColleaguePrg.FactorialNumber(5);

            //ColleaguePrg.DisplayFibonacciNumberByRecursion(1);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(2);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(3);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(4);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(5);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(6);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(7);
            //ColleaguePrg.DisplayFibonacciNumberByRecursion(8);
            #endregion


            #region Get Unique Char From String
            //ColleaguePrg.Get1stUniqueCharFromString("avanish Patel");
            //ColleaguePrg.GetNonRepeatedCharFromString("avanish Patel");
            #endregion


            #region Reversal OfString
            //ColleaguePrg.ReverseOfString("Avnish");
            //Console.WriteLine();

            //ColleaguePrg.ReverseOfString("Avnish Patel");
            //Console.WriteLine();

            //ColleaguePrg.ReverseOfString("AbcbA");
            //ColleaguePrg.ReverseOfWordFromStatement("Avnish Patel Rmp"); 
            #endregion


            #region Reverse Number
            //Console.WriteLine(ColleaguePrg.ReverseNumber(123));
            //Console.WriteLine(ColleaguePrg.ReverseNumber(1034));
            #endregion


            #region find nth Largest number (with/without index)
            //ColleaguePrg.LargestNumberWithIndexFromArray([40,70, 20, 10, 60, 30, 50]);
            //ColleaguePrg.LargestNumberWithIndexFromArray([40, 20,70, 10, 60, 30, 50]);


            //ColleaguePrg.nthLargestNumberFromArray(6);
            //ColleaguePrg.nthLargestNumberFromArray(8); 
            #endregion


            #region Duplicate char
            //ColleaguePrg.RemoveDuplicateValueFromArray(); 
            //ColleaguePrg.ListDuplicateValueFromArray();

            //ColleaguePrg.RemoveDuplicateValueButContainAtLeatOnceFromArray();
            //ColleaguePrg.RemoveDuplicateValueButNotUsenewArray(); 
            #endregion


            #region Is BracketPair : {[()]} / {[)(]} / {[[()]}
            //ColleaguePrg.BracketPair("{[()]}");
            //ColleaguePrg.BracketPair("{[)(]}");
            //ColleaguePrg.BracketPair("{[([)]}");
            //ColleaguePrg.BracketPair("{[[()]}"); 
            #endregion


            //Course_DeleteDemo.SampleMethod();

            #region base keyword unerstanding
            //GrandChildClass grandChild = new GrandChildClass();
            //grandChild.Greet();
            #endregion

            #region LINQ
            //int[] arr = { 1, 2, 3 };

            //var result = arr.Select(x => x * 2).FirstOrDefault();
            //Console.WriteLine(result);  // 2

            //var result22 = arr.Select(x => x * 2);
            //Console.WriteLine(string.Join(",", result22)); // 2,4,6 
            #endregion

            #region boxing unboxing
            //int x = 10;
            //object obj = x;
            //object obj2 = obj;
            //x = 20;
            //Console.WriteLine("obj  " + obj);
            //Console.WriteLine("obj2 " + obj2); Console.WriteLine();

            //obj = 5;
            //Console.WriteLine("obj  " + obj);
            //Console.WriteLine("obj2 " + obj2); 
            #endregion

            // BracesMatch
            BracesMatch.CheckBraces();
        }

    }
}
