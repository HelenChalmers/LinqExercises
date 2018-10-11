using System;
using System.Linq;
using System.Collections.Generic;
// using System.Collections.Generic.List

namespace linqexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits 
            where fruit.StartsWith("L")
            select fruit;

            foreach (string LF in LFruits)
        {
            // Console.WriteLine($"{LF}");
        }



            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
            {
                foreach(int n in fourSixMultiples)
                {
                    // Console.WriteLine($"{n}");
                }
                
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

                List<string> descend = names.OrderByDescending(n => n).ToList();

            //     IEnumerable<string> descend = (from name in names
            //         orderby name descending
            //         select name).ToList();

            {
                foreach(string n in descend)
                {
                    // Console.WriteLine($"{n}");
                }
                
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> collection = from A in numbers2
            orderby A ascending
            select A;

            foreach (int A in collection)
        {
            Console.WriteLine($"{A}");
        }

        }
    }
}
