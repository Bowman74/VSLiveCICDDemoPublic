using System;
using NUnit.Framework;

namespace BuildTest.UnitTests.Droid.Services
{
    [TestFixture]
    public class OsInformation
    {
        [Test]
        public void ReturnVersionInformation()
        {
            var osInformation = new BuildTest.Droid.Services.OsInformation();
            var version = osInformation.GetVersionInformation();
            Assert.AreNotEqual(string.Empty, version);
        }
    }
}
