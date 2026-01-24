using CodePractice.Opps;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

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

            #region Braces Match
            //BracesMatch.CheckBraces();
            #endregion


            #region Inheritance + overriding

            //Console.WriteLine("\r\nParentCls parentObj = new ParentCls();");

            //ParentCls parentObj = new ParentCls();
            //Console.Write("parentObj.Test1() - ");
            //parentObj.Test1();  // op : From Parent class: Test 1()

            //Console.Write("parentObj.Test2() - ");
            //parentObj.Test2();  // op : From Parent class: Test 2()



            //ChildCls childObj = new ChildCls();
            //Console.WriteLine("\r\nChildCls childObj = new ChildCls();");

            //Console.Write("childObj.Test1() - ");
            //childObj.Test1();   // op : From Child class: Test 1 - Bcz Test1() method in clild class re-defined using "new" 

            //Console.Write("childObj.Test2() - ");
            //childObj.Test2();   // op : From Child class: Test 2 - Bcz Test2() method in clild class "override"

            ////childObj.FromChildCallParentMathod();



            //Console.WriteLine("\r\nParentCls parentClsObj_InitialisedByChildClass = new ChildCls();");
            //ParentCls parentClsObj_InitialisedByChildClass = new ChildCls();

            //Console.Write("parentClsObj_InitialisedByChildClass.Test1() - ");
            //parentClsObj_InitialisedByChildClass.Test1(); // op : From Parent class: Test 1
            //                                              // When Parent class object initialised by Child class object and
            //                                              // in child class, Test1() method again defined using NEW keyword,
            //                                              // then aslo object of Parent Class will call method's of Parent class

            //// NOTE 
            //Console.Write("parentClsObj_InitialisedByChildClass.Test2() - ");
            //parentClsObj_InitialisedByChildClass.Test2(); // op : From Child class: Test 2
            //                                              // When Parent class object initialised by Child class object and
            //                                              // in child class, Test2() method OVERRIDE,
            //                                              // then object of Parent Class call will call override method of child class

            //// NOTE : Error - Not possible
            ////parentClsObj_InitialisedByChildClass.Test3();

            #endregion

            //ArrayClass.GetIndexOfLastOccurranceNumber();
            //ArrayClass.MaximumSubarray();


            #region Generic <T>

            #region GENERIC : create a list containing integer values
            //Generic<int> list1 = new Generic<int>();
            //var integerlist = list1.ReturnListOfAnyDatatype(1, 2, 3);
            //Console.WriteLine("Elements of Integer List are:");
            //foreach (var i in integerlist)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region GENERIC : create a list containing string values
            //Generic<string> list2 = new Generic<string>();
            //var stringList = list2.ReturnListOfAnyDatatype("California", "NewYork", "Mumbai");
            //Console.WriteLine("Elements of string List are:");
            //foreach (var i in stringList)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region GENERIC : create a list containing objects
            //Generic<object> listThree = new Generic<object>();
            //var objectList = listThree.ReturnListOfAnyDatatype(1, 23.5, "Hello");
            //Console.WriteLine("Elements of string List are:");
            //foreach (var i in objectList)
            //{
            //    Console.WriteLine(i);
            //}
            /* You can observe that the list is created even though
             * the elements are of different types. This is because
             * we have created a list of object type Generic<object> which will 
             * accept elements of any data type */
            #endregion
            #endregion

            #region List 
            //IList<int> bookQuantity = new List<int>();
            //bookQuantity.Add(20);
            //bookQuantity.Add(10);
            //bookQuantity.Add(15);

            //// Guess o/p of bellow line of code
            //Console.WriteLine(bookQuantity.Remove(30)); // False , because 30 is not present in list
            //Console.WriteLine(bookQuantity.Remove(20)); // True , because 20 is present in list and will be removed 
            #endregion

            #region Inheritance Demo
            //A a = new C();
            //a.Show();


            //C c = new C();
            //c.Show();


            #region inheritance + protected access
            Musician musician = new Musician();
            musician.DisplayAge();
            //Console.WriteLine(musician.age); // error: 'Artist.age' is inaccessible due to its protection level 
            #endregion

            #endregion

            #region LINQ Demo
            //LINQ_Demo.ReadDataFromTxtFile();
            //LINQ_Demo.SimpleQuery();
            //LINQ_Demo.SelectManyDemo(); 
            #endregion

            Console.ReadKey();
        }

    }
}
