using System;
using System.Collections.Generic;

namespace CodePractice
{
    public class Dictionary_ForEach
    {
        public static void DisplayAge()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>()
            {
                {"Allen",25 },
                {"Solley",30 },
                {"Raymond",20 }
            };

            // Iterate over dictionary
            foreach (KeyValuePair<string, int> pair in ages)
            {
                Console.WriteLine("{0} is {1} year old", pair.Key, pair.Value);
            }

        }


        public static void DisplayDesignationWithExperience() {
            Console.WriteLine();
            Dictionary<string, int> nameAgePair = new Dictionary<string, int>()
            {
                {"Trainee",0 },
                {"SE",3 },
                {"SSE",5 },
                { "TL",7 }
            };

            foreach (KeyValuePair<string,int> nameAgeItem in nameAgePair)
            {
                Console.WriteLine("{0} with experience of year {1}", nameAgeItem.Key, nameAgeItem.Value);
            }

        }

    }
}

