using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace Dynamic_Asm_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain curAppDomain = Thread.GetDomain();
            CreateMyAsm(curAppDomain);
            Assembly a = Assembly.Load("MyAssembly");

            Type hello = a.GetType("MyAssembly.HelloWorld");
            string msg = "Dev";
            object[] ctorArgs = new Object[1];
            ctorArgs[0] = msg;
            object obj = Activator.CreateInstance(hello, ctorArgs);
            MethodInfo mi = hello.GetMethod("SayHello");
            mi.Invoke(obj, null);
            mi = hello.GetMethod("GetMsg");
            Console.WriteLine(mi.Invoke(obj, null));
        }
        public static void CreateMyAsm(AppDomain curAppDomain)
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "MyAssembly";
            assemblyName.Version = new Version("1.0.0.0");

            AssemblyBuilder assembly = curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
            ModuleBuilder module = assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");
            TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);
            FieldBuilder msgField = helloWorldClass.DefineField("theMessage", Type.GetType("System.String"), FieldAttributes.Private);
            Type[] constructorArgs = new Type[1];
            constructorArgs[0] = typeof(String);
            ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs);
            ILGenerator constructorIL = constructor.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);
            Type objectClass = typeof(object);
            ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
            constructorIL.Emit(OpCodes.Call, superConstructor);
            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, msgField);
            constructorIL.Emit(OpCodes.Ret);

            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);

            MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof(string), null);
            ILGenerator methodIL = getMsgMethod.GetILGenerator();
            methodIL.Emit(OpCodes.Ldarg_0);
            methodIL.Emit(OpCodes.Ldfld, msgField);
            methodIL.Emit(OpCodes.Ret);
        }
    }
}
