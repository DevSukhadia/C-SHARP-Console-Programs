using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BInarySerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serializaton of string object

            String writeData = "Microsoft .NET Framework 2.0";
            FileStream writeStream = new FileStream("C:\\StringObject.Data", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, writeData);
            writeStream.Close();

            //DeSerialization of String Object
            FileStream readStream = new FileStream("C:\\StringObject.Data", FileMode.Open);
            String readData = (String)formatter.Deserialize(readStream);
            readStream.Close();
            Console.WriteLine(readData);

        }
    }
}
