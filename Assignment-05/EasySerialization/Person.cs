using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace EasySerialization
{
    [DataContract]
    [JsonObject]
    public class Person
    {
        [DataMember]
        public int Age { get; set; }

        /// <summary>
        /// Json.Net is "opt-out" so we have to explicitly ignore this attribute.
        /// Data Contracts are "opt-in" so it is ignored by default
        /// </summary>
        [JsonIgnore]
        public double Funds { get; set; }

        [DataMember(Name = "Funds")]
        public string FundsDisplay { get { return Funds.ToString("C"); } set { } }

        [DataMember]
        public Cat Cat { get; set; }
    }
}
