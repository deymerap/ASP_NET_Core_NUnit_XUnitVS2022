using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    public class BankAccount
    {
        public int Balance { get; set; }
        private ILoggerGen _loggerGen;
        public BankAccount(ILoggerGen loggerGen)
        {
            _loggerGen = loggerGen;
            Balance = 0;
        }

        public bool Deposit(int amount)
        {
            _loggerGen.Message($"Adding money to the account. New amount:{amount}");
            Balance += amount;
            return true;
        }

        public bool Withdrawal(int amount)
        {
            if (amount <= Balance)
            {
                _loggerGen.Message($"Withdrawing money to the account. New amount:{amount}");
                Balance -= amount;
                return true;
            }
            return false;

        }

        public int GetBalance()
        {
            _loggerGen.Message($"Account money. amount:{Balance}");
            return Balance;
        }

    }
}
