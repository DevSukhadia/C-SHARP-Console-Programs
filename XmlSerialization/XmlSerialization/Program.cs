using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Dev";
            person.Age = 18;
            person.Nicknames.Add("1st name");
            person.Nicknames.Add("2nd name");

            string xml = GenericSerializer.Serialize(person);
            Console.WriteLine(xml);

            Person deserializedPerson = GenericSerializer.Deserialize<Person>(xml);

            Console.WriteLine("Person Name: {0}", deserializedPerson.Name);
            Console.Read();
        }
    }
}
