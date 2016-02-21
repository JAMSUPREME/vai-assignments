using System;
using System.Collections.Generic;
using System.Linq;
using Vai.Assn3.Part_00;
using Vai.Assn3.Part_01;
using Vai.Assn3.Part_02;

namespace Vai.Assn3
{
    class Program
    {
        static void Main(string[] args)
        {
            // This assignmnet has a few parts
            // First I will show how basic lambda expressions work
            // Then you'll do some exercises that help you use lambda expressions

            // Part 00 is pre-requisite to your assignment.
            // Read the code and comments in Part 0 to understand LINQ and Lambda expressions and
            //    how they work together
            //Part00Linq.Execute();               // you can comment this line out to avoid cluttering the console when you start your assignment

            // 
            // Once you feel comfortable that you understand all the things mentioned in Part 00,
            //    you can start the assignment below!
            //

            //
            // Now your assignment breaks into two parts:
            // 1) Figure out how to use lambda expressions with LINQ to do useful things
            // 2) See some other interesting uses for lambda expressions
            // 

            // Part 1
            Part01Linq.Execute();

            // Part 2
            Part02Linq.Execute();

            Console.WriteLine();
            Console.WriteLine("...all done...");
            Console.Read();
        }
    }
}
