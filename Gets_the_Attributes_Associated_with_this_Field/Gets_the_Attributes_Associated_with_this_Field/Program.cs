using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace Gets_the_Attributes_Associated_with_this_Field
{
    public class Demo
    {
        private string m_field = "Private String";
     
        public string Field = "Public String";
        
        public const string Field_C = "Const String";
    }
    public class MyFieldAttributes
    {
        public static void Main()
        {
            Demo d = new Demo();

            Type myType = typeof(Demo);
            FieldInfo fiPrivate = myType.GetField("m_field", BindingFlags.NonPublic | BindingFlags.Instance);
            DisplayField(d, fiPrivate);

            FieldInfo fiPublic = myType.GetField("Field", BindingFlags.Public | BindingFlags.Instance);
            DisplayField(d, fiPublic);

            FieldInfo fiStatic = myType.GetField("Field_C", BindingFlags.Public | BindingFlags.Static);
            DisplayField(d, fiStatic);
        }
        static void DisplayField(object obj, FieldInfo f)
        {
            Console.WriteLine("{0} = \"{1}\"; attributes: {2}", f.Name, f.GetValue(obj), f.Attributes);
        }
    }
}
