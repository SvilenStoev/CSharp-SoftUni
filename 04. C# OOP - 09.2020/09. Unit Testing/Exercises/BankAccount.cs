using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class BankAccount
    {
        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }
    }
}
