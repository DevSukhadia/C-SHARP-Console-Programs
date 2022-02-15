#define AAA
#define RELEASE


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace elif
{
    class Program
    {
        static void Main(string[] args)
        {
            #if RELEASE
                Console.WriteLine("Complied for AAA version");
            #endif
            
            #if AAA
                Console.WriteLine("Complied for RELEASE version");
            #else
                Console.WriteLine("Complied for internal Testing"); 
            #endif

        }
    }
}
