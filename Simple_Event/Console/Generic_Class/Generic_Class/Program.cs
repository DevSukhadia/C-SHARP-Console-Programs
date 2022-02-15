using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Class
{
    class GenericClass<T>
    {
        T myObject;

        public GenericClass(T o)
        {
            myObject = o;   
        }
        public T getMyObject()
        {
            return myObject;
        }
    }
    class GenericClass2<T> : GenericClass<T>
    { 
        public GenericClass2(T o) : base(o)
        { }
    }
    class Test
    {
        public static void Main()
        {
            GenericClass2<string> g2  = new GenericClass2<string>("Dev Sukhadia");
        
            Console.WriteLine(g2.getMyObject());
        }
    }
}
