using System;
using NUnit.Framework;
using RevitTest.DA.Utils;

namespace RevitTest.DA
{
    public class OpenRevitTests : OneTimeOpenDocumentTest
    {
        [Test]
        public void RevitTests_Title()
        {
            Assert.IsNotNull(document);
            Console.WriteLine(document.Title);
        }
    }
}
