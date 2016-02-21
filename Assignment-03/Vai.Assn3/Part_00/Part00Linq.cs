using System;
using System.Collections.Generic;
using System.Linq;

namespace Vai.Assn3.Part_00
{
    public static class Part00Linq
    {
        public static void Execute()
        {
            // This is an "IEnumerable"
            // This is the most important class when dealing with collections,
            //   and is the class that enables using LINQ (which uses lambda expressions)
            IEnumerable<int> numbers = Enumerable.Range(1, 10); // Enumerable.Range just makes a collection of ints

            // We have some numbers, but we haven't done anything useful with them
            // LINQ is useful because it is a lot like SQL, and you can do just about everything SQL can do
            Console.WriteLine("Biggest number: " + numbers.Max());
            Console.WriteLine("Average number: " + numbers.Average());
            Console.WriteLine();

            // There is also a SQL-style syntax
            var numbersBiggerThan5 = from n in numbers
                                     where n > 5
                                     select n;
            Console.WriteLine("A number bigger than 5: " + numbersBiggerThan5.First());
            Console.WriteLine();

            // You may not understand it now, but one important thing to learn about
            //     IEnumerable is that it will always re-evaluate unless you do .ToList()
            // For example:
            int timesEnumerableRan = 0;
            IEnumerable<int> numbersAlwaysEval = Enumerable.Range(1, 10).Select(x =>
            {
                timesEnumerableRan++;
                // Console.WriteLine("Running IEnumerable for number: " + x); // if you want, you can print to see this in action
                return x;
            });

            // so whenever we get anything from that collection, it runs all over again
            var biggestNumber = numbersAlwaysEval.Max();
            var smallestNumber = numbersAlwaysEval.Min();
            Console.WriteLine("The enumerable ran " + timesEnumerableRan + " times.");

            // so normally it is common to use .ToList() when you have an IEnumerable, that way you know it won't execute too many times
            // Otherwise, you might accidentally make 5 DB calls instead of just 1!
            int timesEnumerableRanWithList = 0;
            var numbersEvalOnce = Enumerable.Range(1, 10).Select(x =>
            {
                timesEnumerableRanWithList++;
                // Console.WriteLine("Running IEnumerable for number: " + x); // if you want, you can print to see this in action
                return x;
            }).ToList(); // see that we add ToList here!

            // Now the enumerable only runs once! (no matter how many operations we do)
            biggestNumber = numbersAlwaysEval.Max();
            smallestNumber = numbersAlwaysEval.Min();
            var avgNumber = numbersAlwaysEval.Average();
            Console.WriteLine("The enumerable ran " + timesEnumerableRanWithList + " times.");
        }
    }
}
