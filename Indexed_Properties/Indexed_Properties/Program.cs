using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexed_Properties
{
    public class Starter
    {
        public static void Main()
        {
            Names obj = new Names();
            Console.WriteLine(obj[1]);
        }
   }
    public class Names
    {
        object[,] _names = { {"V", 27}, {"B", 35}, {"D", 29}};
        public object this[int index]
        {
            get
            {
                return _names[index, 0] + " " + _names[index, 1];
            }
        }
    }
}
