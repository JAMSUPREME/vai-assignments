using System;
using System.Collections.Generic;
using System.Linq;
using Vai.Assn3.Models;

namespace Vai.Assn3.Factories
{
    public static class PersonFactory
    {
        private static readonly Dictionary<int, string> Names = new Dictionary<int, string>
        {
            {0, "Ted"},
            {1, "Steve"},
            {2, "Guy"},
            {3, "Zoolander"},
            {4, "Bill"},
            {5, "Harris"},
            {6, "Hamiltion"},
            {7, "Dr. Evil"},
            {8, "That Guy"},
            {9, "Blob"},
        };
        private static int counter = 0;
        private static Random r = new Random();

        public static Person Get()
        {
            counter++;

            Person person = new Person();
            int remainder = counter % 10;
            person.Age = remainder + r.Next(100);
            person.Name = Names[remainder] + counter;
            person.Cat = CatFactory.Get();

            return person;
        }

        public static IEnumerable<Person> Get(int amount)
        {
            return Enumerable.Range(0, amount).Select(x => Get());
        } 
    }
}
