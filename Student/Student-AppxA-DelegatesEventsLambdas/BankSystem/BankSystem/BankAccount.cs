using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankAccount
    {
        // Fields.
        private string accountHolder;
        private double balance;

        // Constructor.
        public BankAccount(string accountHolder)
        {
            this.accountHolder = accountHolder;
            this.balance = 0;
        }

        // Methods.
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {accountHolder}, balance {balance:C}";
        }
    }
}
