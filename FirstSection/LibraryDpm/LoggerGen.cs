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
    }
    public class LoggerGen : ILoggerGen
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LoggerGenFake : ILoggerGen
    {
        public void Message(string message)
        {
            
        }
    }
}
