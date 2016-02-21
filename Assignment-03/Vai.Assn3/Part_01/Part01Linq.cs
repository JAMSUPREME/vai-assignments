using System;
using System.Linq;
using Vai.Assn3.Factories;

namespace Vai.Assn3.Part_01
{
    public static class Part01Linq
    {
        public static void Execute()
        {
            // We have a "person factory" which gives us a bunch of people
            // We'll imagine that this is like our "database access layer"
            // Each person also has a cat
            // In some cases, we will want information about people, and sometimes we might need to filter information
            //    based on both people and cats!
            var people = PersonFactory.Get(50);

            // to help you get started, I'll show you how to get the top 10 oldest people
            var oldestPeople = people
                                .OrderByDescending(p => p.Age) // .OrderBy() and .OrderByDescending are like ORDER BY in SQL
                                .Take(10); // Take() is like TOP in SQL
            foreach (var person in oldestPeople)
            {
                Console.WriteLine("Person: " + person.Name + " is " + person.Age + " years old. Their cat is " + person.Cat.Age + " years old");
            }

            //
            // Now the fun part begins! You get to do it yourself
            //

            // 1) Get the average person age


            // 2) Get the 1 person with the oldest cat


            // 3) Get all cats younger than 20


            // 4) Get all people with "z" in their name


            // 5) Select the first cat name with a "W" in it (only the name, not the whole cat)


            // 6) Get the 10th - 20th oldest people (hint: use Skip and Take)


        }
    }
}
