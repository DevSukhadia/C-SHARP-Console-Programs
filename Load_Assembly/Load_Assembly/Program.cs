using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Diagnostics;

namespace Load_Assembly
{
    public class AssemblyUtils
    {
        public static string GetAssemblyName(string[] args)
        {
            string assemblyName;

            if (0 == args.Length)
            {
                Process p = Process.GetCurrentProcess();
                assemblyName = p.ProcessName + ".exe";
            }
            else 
                assemblyName = args[0];
            
            return assemblyName;
        }
    }
    class GetModulesApp
    {
        public static void Main(string[] args)
        {
            string assemblyName = AssemblyUtils.GetAssemblyName(args);

            Console.WriteLine("Loading into for " + assemblyName);
            Assembly a = Assembly.LoadFrom(assemblyName);

            Module[] modules = a.GetModules();
            foreach (Module m in modules)
            {
                Console.WriteLine("Module: " + m.Name);

            }
        }
    }
}
