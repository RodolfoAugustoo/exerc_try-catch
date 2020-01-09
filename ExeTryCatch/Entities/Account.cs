using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExeTryCatch.Entities.DomainExceptions;

namespace ExeTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void DepositAmount(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Error! This amount exceeds withdraw limit! ");
            }
            if (Balance < amount)
            {
                throw new DomainException("Error! Balance not enough to withdraw! ");
            }
            
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
