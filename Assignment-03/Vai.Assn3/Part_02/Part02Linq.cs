using System;
using Vai.Assn3.Factories;
using Vai.Assn3.Models;

namespace Vai.Assn3.Part_02
{
    public static class Part02Linq
    {
        public static void Execute()
        {
            // Most of the time you will use lambda expressions with LINQ
            // However, it can serve useful purposes in lots of other ways

            //
            // Example 01: Mapping objects
            // using lambda expressions, you can easily map one object to another
            Person person = PersonFactory.Get();
            var dto = MapToDto(person, p =>
            {
                return new PersonDto { ConcatenatedInfo = p.Name + p.Age + p.Cat.Name };
            });
            // the above code might look a little silly by itself, but combined with factories and code that uses Generics, it can be useful

            //
            // Example 02: Extending code in useful ways
            // we can imagine some existing code that might be extensible in some way to allow for special modifications
            PersonDto customPerson = new PersonDto(s =>
            {
                return "SUPER COOL " + s;
            });
            customPerson.ConcatenatedInfo = "Justin";
            Console.WriteLine(customPerson.ConcatenatedInfo);

            //
            // Assignment: Think of a cool way you can use lambda expressions and implement something
            // It can be whatever you want
            //
        }

        public static PersonDto MapToDto(Person p, Func<Person, PersonDto> actionToTake)
        {
            return actionToTake(p);
        }
    }

    /// <summary>
    /// DTO stands for "data transfer object"
    /// and it is common for a Web API or service to expose a DTO that differs from the original object
    /// </summary>
    public class PersonDto
    {
        private readonly Func<string, string> specialFormatting = null;

        public PersonDto()
        {

        }
        public PersonDto(Func<string, string> specialFormatting)
        {
            this.specialFormatting = specialFormatting;
        }

        private string concatInfo = null;

        public string ConcatenatedInfo
        {
            get
            {
                if (specialFormatting != null)
                {
                    return specialFormatting(this.concatInfo);
                }
                return this.concatInfo;
            }
            set
            {
                this.concatInfo = value;
            }
        }
    }
}
