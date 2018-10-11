using System;
using System.Linq;
using System.Collections.Generic;
// using System.Collections.Generic.List

namespace linqexercise
{

    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
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
            // Console.WriteLine($"{A}");
        }

        // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
            // IEnumerable<int> collectNums = from B in numbers3
            //     select B;
            Console.WriteLine($"The number of integers is {numbers3.Count()}");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            IEnumerable<double> collectNums2 = from C in purchases
                select C;
            Console.WriteLine($"The total is {collectNums2.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
                // IEnumerable<double> highestPrice = from D in prices
                // orderby D descending
                // select D;
                Console.WriteLine($"The highest price is  {prices.Max()}");


// ------------------------------------------------------------------------------------------------------------------
                
                
                // Partitioning Operations
        /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
        List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };
        var squared = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);
            Console.WriteLine("------------------------");
            
        foreach (int n in squared)
        {
            Console.WriteLine($"{n}");
        }
        Console.WriteLine("------------------------");


        // Using Custom Types
        // Build a collection of customers who are millionaires
    
        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        var millionaires = customers.Where(n => n.Balance >= 1_000_000);
        foreach (Customer AB in millionaires)
        {
            Console.WriteLine($"{AB.Name} has a Balance of {AB.Balance}");
        }
 Console.WriteLine("------------------------");

        var millionaires2 = from mill in customers
        where mill.Balance >= 1_000_000
        group mill by mill.Bank into BankList
        select new {
            ReportBank = BankList.Key,
            MillPerBank = BankList.ToList().Count()
        };

        foreach(var bank in millionaires2 )
        {
            Console.WriteLine($"{bank.ReportBank}: {bank.MillPerBank}");
        }

            //  //dealing with kids list
            //     group customer by customer.Bank into BankGroup
            // //now dealing with neighborhoodGroup list
            //     select new SalesReportEntry {
            //         ReportNeighborhood = neighborhoodGroup.Key, 
            //         ReportTotalSales = neighborhoodGroup.Sum(kidObj => kidObj.Sales)
            //     }).OrderByDescending(sr => sr.ReportTotalSales).ToList();


        /*
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
        */




}

            }
    }

