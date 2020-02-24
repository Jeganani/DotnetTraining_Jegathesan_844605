using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Reflection;
namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly assembly = Assembly.Load("ClassLibrary1");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine("Base:{0}", type.BaseType);
                Console.WriteLine("Name:{0}", type.Name);
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("method name:{0}", method.Name);
                    Console.WriteLine("return type:{0}", method.ReturnType);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo param in parameters)
                    {
                        Console.WriteLine("parameter name:{0}", param.Name);
                        Console.WriteLine("parameter type:{0}", param.ParameterType);
                        Console.WriteLine("-----------------------------------------");
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                Console.WriteLine("-----------------------------------------");

                Console.ReadKey();
            }

        }
    }
}
