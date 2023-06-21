using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class BankAccount
    {
        public string accountNumber;
        public double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public abstract void Withdraw(double amount);
    }

    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, double balance) : base(accountNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Money");
            }
            else
            {
                balance -= amount;
            }
        }
    }

    class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountNumber, double balance, double overdraftLimit)
            : base(accountNumber, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
