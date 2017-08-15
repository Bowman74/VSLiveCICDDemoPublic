using System;
using System.Collections.Generic;
using BuildTest.Models;

namespace BuildTest.Services
{
    public interface IAccountServices
    {
        IList<IAccount> GetAccounts();
    }
}
