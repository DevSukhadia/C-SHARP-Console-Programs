using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlSerialization
{
    public class Person
    {
        public int Age { get; set; }
        
        public string Name { get;  set; }
        
        public List<string> Nicknames { get; set; }

        public Person()
        {
            Nicknames = new List<string>();     
        }
    }
}
