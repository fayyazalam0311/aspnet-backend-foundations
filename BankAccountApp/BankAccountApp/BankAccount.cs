using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp
{
    public class BankAccount
    {
        public string Owner {  get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }
        public BankAccount (string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;

        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Deposit amount must be greater than zero.";
            }
            if (amount >= 20000)
            {
                return "Deposit amount must be less than $20,000.";
            }
            Balance += amount;
            return $"Deposited {amount:C}. New balance: {Balance:C}.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Withdrawal amount must be greater than zero.";
            }
            if (amount > Balance)
            {
                return "Insufficient funds for this withdrawal.";
            }
            Balance -= amount;
            return $"Withdrew {amount:C}. New balance: {Balance:C}.";
        }

        internal static void Add(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }
    }
}
