using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Reflection.Emit;

namespace Create_Assembly
{
    class CodeGenerator
    {
        Type t;
        public static void Main()
        {
            CodeGenerator codeGen = new CodeGenerator();
            Type t = codeGen.T;

            if (t != null)
            {
                object o = Activator.CreateInstance(t);
                MethodInfo helloWorld = t.GetMethod("HelloWorld");
                if (helloWorld != null)
                {
                    //Run the HelloWorld Method
                    helloWorld.Invoke(o, null);
                }
                else
                    Console.WriteLine("Could not Retrieve Method");
            }
            else
                Console.WriteLine("Could not Access Type");
        }
        public CodeGenerator()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;

            AssemblyName assemName = new AssemblyName();
            assemName.Name = "Dev";

            AssemblyBuilder assemBuilder = currentDomain.DefineDynamicAssembly(assemName, AssemblyBuilderAccess.Run);
            
            ModuleBuilder moduleBuilder = assemBuilder.DefineDynamicModule("MyModule");

            TypeBuilder typeBuilder = moduleBuilder.DefineType("MyClass", TypeAttributes.Public);

            MethodBuilder methodBuilder = typeBuilder.DefineMethod("HelloWorld", MethodAttributes.Public, null, null);

            ILGenerator msilG = methodBuilder.GetILGenerator();
            msilG.EmitWriteLine("Dev Sukhadia");
            msilG.Emit(OpCodes.Ret);

            t = typeBuilder.CreateType();
        }
        public Type T 
        {
            get 
            {
                return this.t;
            }
        }
    }
}
