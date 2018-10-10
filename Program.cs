using System;
using System.Linq;
using System.Collections.Generic;

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
            Console.WriteLine($"{LF}");
        }



            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            // IEnumerable<int> fourSixMultiples = numbers.Where();
        }
    }
}
