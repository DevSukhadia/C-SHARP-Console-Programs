using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace ArrayList_Object_to_SOAP_File
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList people = new ArrayList();
            people.Add("G");
            people.Add("L");
            people.Add("A");

            SoapSerialize(poeple);
            ArrayList soapPeople = SoapDeserialize();

            Console.WriteLine("\nSOAP poeple:");
            foreach (string s in soapPeople)
                Console.WriteLine("\t" + s);     
        }
        private static void SoapSerialize(ArrayList lsit)
        {
            using (FileStream str = File.Create("people.SOAP"))
            {
                SoapFormatter sf = new SoapFormatter();
                people = (ArrayList)sf.Deserialize(str);
            }
            return people;
        }
    }
}
