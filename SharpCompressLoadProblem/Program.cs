using System;
using System.IO;
using System.Reflection;

namespace SharpCompressLoadProblem
{
    internal class Program
    {
        static string subroutineUrl = @"C:\Users\KaGaMi\source\repos\SharpCompressLoadProblem\Subroutine\bin\Release\netcoreapp3.1\publish";
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
            var assembly = Assembly.LoadFrom(Path.Combine(subroutineUrl, "Subroutine.dll"));
            var type = assembly.GetType("Subroutine.Class1");
            object obj = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Run");
            method.Invoke(obj, null);
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
        {
            string dllName = e.Name.Split(new[] { ',' })[0] + ".dll";
            return Assembly.LoadFrom(Path.Combine(subroutineUrl, dllName));
        }
    }
}
