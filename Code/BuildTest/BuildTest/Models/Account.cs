using System;
using Validation;

namespace BuildTest.Models
{
    public sealed class Account : IAccount
    {
        private double _creditLimit = 0;
        public double CreditLimit
        {
            get
            {
                return _creditLimit;
            }

            set
            {
                Requires.Range(value >= 0, "CreditLimit");
                Requires.Range(value <= 50000, "CreditLimit");
                _creditLimit = value;
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string PhoneNumber
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
