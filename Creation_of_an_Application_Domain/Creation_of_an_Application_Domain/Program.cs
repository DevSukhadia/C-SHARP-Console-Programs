using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creation_of_an_Application_Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain d = AppDomain.CreateDomain("NewDomain");
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine(d.FriendlyName);
          /*
           * Print All Assemblies in Curent Domain
           *
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Console.WriteLine("This Call loaded System.Windows.Forms.dll and Sustem.dll");

            Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
            Console.WriteLine("Here are the assemblies loaded in {0}\n", defaultAD.FriendlyName);
            foreach (Assembly a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}", a.GetName().Version);
            }
            return 0;
           * */
        }
    }
}
