﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var LFruits = fruits.Where(fruits =>
            {
                return fruits.StartsWith("L");
            });
            foreach (var fruit in LFruits)
            {
                Console.WriteLine($"{fruit}");
            }
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n =>
            {
                return (n % 4 == 0 || n % 6 == 0);
            });

            foreach (var n in fourSixMultiples)
            {
                Console.WriteLine(n);
            }
            // ordering operations

            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();

            foreach (var name in descend)
            {
                Console.WriteLine($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersList = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> ascendingNumbers = from ascendingNumber in numbersList
            orderby ascendingNumber ascending
            select ascendingNumber;

            // Display each number that was the acceptable size
            foreach (int ascendingNumber in ascendingNumbers)
            {
                Console.WriteLine(ascendingNumber);
            }

            // Output how many numbers are in this list
            List<int> numbersCount = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var numbersCountSum = numbersCount.Count();
            Console.WriteLine(numbersCountSum);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            var totalPurchases = purchases.Sum();
            Console.WriteLine($"Total sum of purchases = $ {(totalPurchases)}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            var mostExpensiveProduct = prices.Max();
            Console.WriteLine($"Our most expensive product is ${mostExpensiveProduct}");

            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            
            var listUntilPerfectSquare = wheresSquaredo.TakeWhile(num =>
            {
                return num % (Math.Sqrt(num)) != 0;
            });
            foreach (var num in listUntilPerfectSquare) {
                Console.WriteLine(num);
            }
        }
    }
}