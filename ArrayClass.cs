using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodePractice
{
    public static class ArrayClass
    {

        /// <summary>
        /// Find the index of the last occurrence of a specified element in an array.
        /// </summary>
        public static void GetIndexOfLastOccurranceNumber()
        {
            int number = 34; // Provide number you want index
            int[] ary = { 1, 3, 34, 3, 1 };

            for (int i = ary.Length - 1; i >= 0; i--)
            {
                if (number == ary[i])
                {
                    Console.Write(i);
                    break;
                }
            }
        }



        // Input: arr[] = {2, 3, -8, 7, -1, 2, 3}
        // Output: 11
        // Explanation: The subarray {7, -1, 2, 3}
        // has the largest sum 11.


        // Input: arr[] = {-2, -4}
        // Output: –2
        // Explanation: The subarray {-2}
        // has the largest sum -2.


        // Input: arr[] = {5, 4, 1, 7, 8}
        // Output: 25
        // Explanation: The subarray {5, 4, 1, 7, 8}
        // has the largest sum 25.
        public static void MaximumSubarray()
        {

            //int[] ary = [ -2, 1, -3, 4, -1, 2, 1, -5, 4 ];  // Sum : 6
            //int[] ary = [ -2, -3, 4, -1, -2, 1, 5, -3];     // Sum : 7
            //int max = ary[0];
            //for (int i = 1; i < ary.Length; i++)
            //{
            //    ary[i] = Math.Max(ary[i], ary[i] + ary[i - 1]);
            //    max = Math.Max(max, ary[i]);
            //}

            //Console.Write(max);

            //int[] a = [ -2, 1, -3, 4, -1, 2, 1, -5, 4 ];
            //int globalmax = a[0];
            //int curr_max = a[0];

            //for (int i = 1; i < a.Length; i++)
            //{
            //    curr_max = Math.Max(a[i], curr_max + a[i]);
            //    globalmax = Math.Max(globalmax, curr_max);
            //}
            //Console.Write(globalmax);
        }


    }
}
