﻿//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace LibraryDpm
//{
//    public class BankAccountXUnitTest
//    {
//        private BankAccount Account;

//        [Fact]
//        public void Deposit_inputAmount100_ReturnTrue()
//        {
//            BankAccount bankAccount = new BankAccount(new LoggerGen());
//            bool vResponse = bankAccount.Deposit(100);
//            Assert.True(vResponse);
//            Assert.Throws(bankAccount.GetBalance, Equal(100));
//        }

//        [Fact]
//        public void Deposit_inputAmount100Mocking_ReturnTrue()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            BankAccount bankAccount = new BankAccount(vMocking.Object);
//            bool vResponse = bankAccount.Deposit(100);
//            Assert.True(vResponse);
//            Assert.Equal(bankAccount.GetBalance, 100);
//        }

//        [Fact]
//        public void Deposit_input100ForWithdrawalMocking_ReturnTrue()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            vMocking.Setup(x => x.LogDatabase("you can this way")).Returns(true);
//            vMocking.Setup(x => x.BalanceBeforeWithdrawal(It.IsAny<int>())).Returns(true);


//            BankAccount bankAccount = new BankAccount(vMocking.Object);
//            bankAccount.Deposit(200);
//            bool vResponseWithdrawal = bankAccount.Withdrawal(100);

//            Assert.IsTrue(vResponseWithdrawal);
//        }

//        [Fact]
//        public void Deposit_input300ForWithdrawalMocking_ReturnFalse()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            vMocking.Setup(x => x.BalanceBeforeWithdrawal(It.Is<int>(x => x > 0))).Returns(false);


//            BankAccount bankAccount = new BankAccount(vMocking.Object);
//            bankAccount.Deposit(200);
//            bool vResponseWithdrawal = bankAccount.Withdrawal(300);

//            Assert.IsFalse(vResponseWithdrawal);
//        }



//        [Fact]
//        public void BankAccountLoggerGen_LogMockingObjReferenceReturnBoolean()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            Cliente vClient = new();    
//            Cliente vClientNotUsed = new();

//            vMocking.Setup(x => x.MessageWithObjReferenceReturnBool(ref vClient)).Returns(true);
//            Assert.IsTrue(vMocking.Object.MessageWithObjReferenceReturnBool(ref vClient));
//            Assert.IsFalse(vMocking.Object.MessageWithObjReferenceReturnBool(ref vClientNotUsed));
//        }


//        [Fact]
//        public void BankAccountLoggerGen_LogMockingProperties_ReturnTrue()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            vMocking.Setup(x => x.TypeLogger).Returns("warning");
//            vMocking.Setup(x => x.PriorityLogger).Returns(10);

//            ////allows to reset variables  before initioalize in setup
//            vMocking.SetupAllProperties();
//            vMocking.Object.PriorityLogger = 100; //Generate error if the value is different from 100
//            vMocking.Object.TypeLogger = "warning";

//            Assert.Throws(vMocking.Object.TypeLogger, Is.EqualTo("warning"));
//            Assert.Throws(vMocking.Object.PriorityLogger, Is.EqualTo(100));


//            //Callbacks
//            string vTempName = "Deymer";
//            vMocking.Setup(x => x.LogDatabase(It.IsAny<string>()))
//                .Returns(true)
//                .Callback((string vAddvalueName) => vTempName += vAddvalueName);

//            vMocking.Object.LogDatabase(" Perea");

//            Assert.Throws(vTempName, Is.EqualTo("Deymer Perea"));
//        }


//        [Fact]
//        public void BankAccountLoggerGen_Verify()
//        {
//            var vMocking = new Mock<ILoggerGen>();
//            BankAccount bankAccount = new(vMocking.Object);
//            bankAccount.Deposit(100);
            
//            Assert.Throws(bankAccount.GetBalance(), Is.EqualTo(100));

//            //check counts times the mock calls the method
//            vMocking.Verify(x => x.Message(It.IsAny<string>()), Times.Exactly(4));
//            vMocking.Verify(x => x.Message("Is another text"), Times.AtLeastOnce);
//            vMocking.VerifySet(x => x.PriorityLogger=100, Times.Once);
//            vMocking.VerifyGet(x => x.PriorityLogger, Times.Once);
//        }

//    }
//}
