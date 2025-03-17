using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace RevitTest.DA
{
    public class ApplicationTests
    {
        [TestCase("ricaun.RevitTest.DA.Application")]
        public void ApplicationTests_Assembly(string assemblyName)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(e=>e.GetName().Name == assemblyName);
            Assert.IsNotNull(assembly);
            Console.WriteLine(assembly);
        }
    }
}
