using System;
using System.Collections.Generic;
using System.Linq;

namespace CodePractice
{
    public class BracesMatch
    {

        // condition 1 :Same number of Open braces must be closed
        // condition 2 : Order must be matter
        // condition 3 : Braces first open then only close, reverse not acceptable
        // condition 4 : Valid input braces : (, {, [, ], }, )
        // condition 5 : if other character availablethen ignore and check above conditions

        public static void CheckBraces()
        {
            string[] listofBraces = { "(())", "([])", "([)]", "([{}])", "}])([{", "([@]){}", "([{{}}])", "{x{@x4@}}", "{x{[@x4@}}}", "{{{[@%@]}}}" };
          /*  (())        : braces matches
              ([])        : braces matches
              ([)]        : braces not matches
              ([{}])      : braces matches
              }])([{      : braces not matches
              ([@]){}     : braces matches
              ([{{}}]);   : braces matches
              {x{@x4@}}   : braces matches
              {x{[@x4@}}} : braces not matches
              {{{[@%@]}}} : braces matches
          */

            foreach (string s in listofBraces)
            {
                Console.Write(s + " : " + IsOpenBracesClosedProperlyInSameOrder(s));
                Console.WriteLine();
            }
        }

        public static string IsOpenBracesClosedProperlyInSameOrder(string input)
        {
            string validbraces = "{[()]}";
            string openbraces = "{[(";

            List<string> inputBraces = new();

            foreach (var str in input)
            {
                var strIp = str.ToString();
                if (validbraces.Contains(str))
                {
                    // check inputBraces
                    if (openbraces.Contains(str))
                    {
                        inputBraces.Add(strIp);
                    }
                    else if (strIp == "}") // Last record 
                    {
                        // remove
                        int id = inputBraces.LastIndexOf("{");
                        if (id > -1 && inputBraces.Count() - 1 == id)
                        {
                            inputBraces.RemoveAt(id); // remove last record
                        }
                        else
                        {
                            inputBraces.Add(strIp);
                        }
                    }
                    else if (strIp == ")") // Last record 
                    {
                        // remove
                        int id = inputBraces.LastIndexOf("(");
                        if (id > -1 && inputBraces.Count() - 1 == id)
                        {
                            inputBraces.RemoveAt(id); // remove last record
                        }
                        else
                        {
                            inputBraces.Add(strIp);
                        }
                    }
                    else if (strIp == "]") // Last record 
                    {
                        // remove
                        int id = inputBraces.LastIndexOf("[");
                        if (id > -1 && inputBraces.Count() - 1 == id)
                        {
                            inputBraces.RemoveAt(id); // remove last record
                        }
                        else
                        {
                            inputBraces.Add(strIp);
                        }
                    }
                }
            }

            return inputBraces.Count() > 0 ? "Braces Not Match" : "Braces Matches";

        }
    }
}
