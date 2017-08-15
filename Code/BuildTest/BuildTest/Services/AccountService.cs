using System;
using System.Collections.Generic;
using BuildTest.Models;

namespace BuildTest.Services
{
    public class AccountService : IAccountServices
    {
        public AccountService()
        {
        }

        public IList<IAccount> GetAccounts()
        {
            var returnValue = new List<IAccount>();
            returnValue.Add(new Account {
                Name = "Magenic",
                PhoneNumber = "111-111-1111",
                CreditLimit = 10000});

            return returnValue;
        }
    }
}
