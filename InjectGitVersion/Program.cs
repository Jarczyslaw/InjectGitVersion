using System;
using System.Reflection;

namespace InjectGitVersion
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var assembly = Assembly.GetEntryAssembly();
            var version = AssemblyInfo.GetAssemblyAttribute<AssemblyFileVersionAttribute>(assembly).Version;

            Console.WriteLine("Version: " + version);
            Console.ReadKey();
        }
    }
}
