using System;
using System.Collections.Generic;
using System.Linq;
using Vai.Assn3.Models;

namespace Vai.Assn3.Factories
{
    public static class CatFactory
    {
        private static readonly Dictionary<int, string> Names = new Dictionary<int, string>
        {
            {0, "Whiskers"},
            {1, "Tiger"},
            {2, "Fluffy"},
            {3, "Grouchy"},
            {4, "Stripes"},
            {5, "Lion"},
            {6, "Poofy"},
            {7, "Dr. Meow"},
            {8, "Pudge-Cat"},
            {9, "Shorty"},
        };
        private static int counter = 0;
        private static Random r = new Random();

        public static Cat Get()
        {
            counter++;

            Cat c = new Cat();
            int remainder = counter%10;
            c.Age = remainder + r.Next(20);
            c.Name = Names[remainder] + counter;

            return c;
        }

        public static IEnumerable<Cat> Get(int amount)
        {
            return Enumerable.Range(0, amount).Select(x => Get());
        } 
    }
}
