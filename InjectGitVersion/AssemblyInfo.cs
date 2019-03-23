using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InjectGitVersion
{
    public static class AssemblyInfo
    {
        public static T GetAssemblyAttribute<T>(Assembly assembly)
            where T : Attribute
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(T), true);
            if ((attributes == null) || (attributes.Length == 0))
            {
                return null;
            }

            return (T)attributes[0];
        }
    }
}
