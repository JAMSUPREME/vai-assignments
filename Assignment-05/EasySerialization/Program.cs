using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using EasySerialization.Todo;
using Newtonsoft.Json;

namespace EasySerialization
{
    class Program
    {
        /// <summary>
        /// Find documentation at the below URLs:
        /// 
        /// XML: https://msdn.microsoft.com/en-us/library/ms733127(v=vs.110).aspx
        /// 
        /// JSON: http://www.newtonsoft.com/json/help/html/Introduction.htm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person p = new Person
            {
                Age = 50,
                Funds = 5708342,
                Cat = new Cat
                {
                    Age = 1,
                    Name = "Fluffy"
                }
            };

            //
            // Using XML
            //

            // Normally this explicit serialization will be done by the web framework for you
            using (var fStream = File.Create(GetAppDir() + "\\person.xml"))
            {
                DataContractSerializer s = new DataContractSerializer(typeof(Person));
                s.WriteObject(fStream, p);
            }

            // You could also write the XML yourself if you needed to
            var xmlDoc = new XDocument(
                new XElement("Person",
                    new XAttribute("Age", p.Age),
                    new XElement("Funds", p.FundsDisplay),
                    new XElement("Cat",
                        new XAttribute("Age", p.Cat.Age),
                        new XElement("Name", p.Cat.Name))
                )
            );
            using (var fStream = File.Create(GetAppDir() + "\\personCustom.xml"))
            {
                using (TextWriter jw = new StreamWriter(fStream))
                {
                    jw.Write(xmlDoc.ToString());
                }
            }

            //
            // Using JSON
            //

            using (var fStream = File.Create(GetAppDir() + "\\person.json"))
            {
                using (StreamWriter sw = new StreamWriter(fStream))
                {
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(jw, p);
                    }
                }
            }

            //
            //
            // ASSIGNMENT: Decorate the "Manager" and "Employee" classes and serialize it into 
            //
            //

            // I've created the object for you so that it will match when serialized correctly
            Manager m = BuildManager();

            // TODO: add attributes to the Employee & Manager classes
            // TODO: put your serialization code here
            // TODO: make sure it matches the output in manager.xml and manager.json


            Console.Read();
        }


        /// <summary>
        /// Moves 2 directories up from /bin/debug
        /// </summary>
        /// <returns></returns>
        static string GetAppDir()
        {
            return String.Join("\\", Environment.CurrentDirectory.Split('\\').Reverse().Skip(2).Reverse());
        }

        /// <summary>
        /// Builds a manager
        /// </summary>
        /// <returns></returns>
        static Manager BuildManager()
        {
            return new Manager
            {
                Age = 55,
                Name = "Gerald",
                Salary = 999000,
                Minions = new []
                {
                    new Employee
                    {
                        Age = 40,
                        Name = "Jim",
                        Salary = 55000
                    },
                     new Employee
                    {
                        Age = 40,
                        Name = "Grunt",
                        Salary = 55000
                    },
                }
            };
        }
    }
}
