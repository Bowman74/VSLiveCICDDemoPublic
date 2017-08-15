using System;
using NUnit.Framework;

namespace BuildTest.UnitTests.iOS.Services
{
    [TestFixture]
    public class OsInformation
    {
    	[Test]
    	public void ReturnVersionInformation()
    	{
    		var osInformation = new BuildTest.iOS.Services.OsInformation();
    		var version = osInformation.GetVersionInformation();
    		Assert.AreNotEqual(string.Empty, version);
    	}
    }
}
