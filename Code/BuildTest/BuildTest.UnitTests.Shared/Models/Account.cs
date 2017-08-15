using System;
using NUnit.Framework;

namespace BuildTest.UnitTests.Shared.Models
{
    [TestFixture]
    public class Account
    {
        [Test]
        public void CreditLimitBelowRange()
        {
            var account = new BuildTest.Models.Account();
            Assert.Throws<ArgumentOutOfRangeException>(() => account.CreditLimit = -1);
        }

        [Test]
        public void CreditLimitAboveRange()
        {
	        var account = new BuildTest.Models.Account();
	        Assert.Throws<ArgumentOutOfRangeException>(() => account.CreditLimit = 50001);
        }

        [Test]
        public void CreditLimitSetIfMin()
        {
            double valueToSet = 0;
            var account = new BuildTest.Models.Account();
	        account.CreditLimit = valueToSet;
            Assert.AreEqual(valueToSet, account.CreditLimit);
        }

        [Test]
        public void CreditLimitSetIfMax()
        {
        	double valueToSet = 50000;
        	var account = new BuildTest.Models.Account();
        	account.CreditLimit = valueToSet;
        	Assert.AreEqual(valueToSet, account.CreditLimit);
        }
    }
}