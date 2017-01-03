using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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

            // Normally this explicit serialization will be done by the web framework for you
            using (var fStream = File.Create(GetAppDir() + "\\person.xml"))
            {
                DataContractSerializer s = new DataContractSerializer(typeof(Person));
                s.WriteObject(fStream, p);
            }

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
    }
}
