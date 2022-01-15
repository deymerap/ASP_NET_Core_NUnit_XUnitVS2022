using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    public interface ILoggerGen
    {
        void Message(string message);
        bool LogDatabase(string message);
        bool BalanceBeforeWithdrawal(int bBeforeWithdrawal);
    }


    public class LoggerGen : ILoggerGen
    {
        public bool BalanceBeforeWithdrawal(int bBeforeWithdrawal)
        {
            if(bBeforeWithdrawal >= 0)
            {
                Console.WriteLine("Success");
                return true;
            }
            Console.WriteLine("Error");
            return false;
        }

        public bool LogDatabase(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LoggerGenFake : ILoggerGen
    {
        public bool BalanceBeforeWithdrawal(int bBeforeWithdrawal)
        {
            return false;
        }

        public bool LogDatabase(string message)
        {
            return false;
        }

        public void Message(string message)
        {
            
        }
    }
}
