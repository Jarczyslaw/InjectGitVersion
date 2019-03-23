using System;
using System.Reflection;

namespace InjectGitVersion
{
    public static class Program
    {
        private static void Main()
        {
            var assembly = Assembly.GetEntryAssembly();
            var version = AssemblyInfo.GetAssemblyAttribute<AssemblyFileVersionAttribute>(assembly).Version;
            var configuration = AssemblyInfo.GetAssemblyAttribute<AssemblyConfigurationAttribute>(assembly).Configuration;

            Console.WriteLine("Version: " + version);
            Console.WriteLine("Configuration: " + configuration);
            Console.ReadKey();
        }
    }
}
