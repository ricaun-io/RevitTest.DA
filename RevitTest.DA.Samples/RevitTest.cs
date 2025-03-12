using System;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using NUnit.Framework;

[assembly: System.Reflection.AssemblyMetadata("NUnit.Application", "RICAUN_REVITTEST_DA_APPLICATION")]
[assembly: System.Reflection.AssemblyMetadata("NUnit.Verbosity", "3")]

namespace RevitTest.DA
{
    public class RevitTests
    {
        protected Application application;

        [OneTimeSetUp]
        public void Setup(Application application)
        {
            this.application = application;
        }

        [Test]
        public void RevitTests_VersionName()
        {
            Assert.IsNotNull(application);
            Console.WriteLine(application.VersionName);
        }

        [Test]
        public void RevitTests_ActiveAddInId()
        {
            Assert.IsNotNull(application);
            Console.WriteLine(application.ActiveAddInId?.GetAddInName());
        }
    }
}
