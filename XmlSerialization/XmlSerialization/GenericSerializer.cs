using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace XmlSerialization
{
    public class GenericSerializer
    {
        private class AUtf8Stringwriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }
        public static string Serialize<F>(F obj)
        {
            Console.WriteLine("Entered Serialize method of our");
            XmlSerializer serializer = new XmlSerializer(typeof(F));
            using (StringWriter writer = new AUtf8Stringwriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
        public static A Deserialize<A>(string xml)
        {
            XmlSerializer Deserializer = new XmlSerializer(typeof(A));
            return (A)Deserializer.Deserialize(new StringReader(xml));
        }
    }
}

