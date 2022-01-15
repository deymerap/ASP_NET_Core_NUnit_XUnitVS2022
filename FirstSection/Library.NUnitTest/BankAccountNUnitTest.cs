using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    [TestFixture]
    public class BankAccountNUnitTest
    {
        private BankAccount Account;

        [SetUp]
        public void ini()
        {
            
        }

        [Test]
        public void Deposit_inputAmount100_ReturnTrue()
        {
            BankAccount bankAccount = new BankAccount(new LoggerGen());
            bool vResponse = bankAccount.Deposit(100);
            Assert.That(vResponse, Is.True);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }

        [Test]
        public void Deposit_inputAmount100Mocking_ReturnTrue()
        {
            var vMocking = new Mock<ILoggerGen>();
            BankAccount bankAccount = new BankAccount(vMocking.Object);
            bool vResponse = bankAccount.Deposit(100);
            Assert.That(vResponse, Is.True);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }

    }
}
