using System;
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

        }

    }
}