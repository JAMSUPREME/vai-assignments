using System.Runtime.Serialization;

namespace EasySerialization
{
    /// <summary>
    /// Doesn't declare any JSON attributes since it is "opt-out" by default.
    /// </summary>
    [DataContract]
    public class Cat
    {
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
