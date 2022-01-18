//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace LibraryDpm
//{
//    public class ClienteXUnitTest
//    {
//        private Cliente vCli;

//        public ClienteXUnitTest()
//        {
//            vCli = new Cliente();
//        }

//        [Fact]
//        public void CreateFullName_InputNameLastName_ReturnFullName()
//        {
//            //Arrange
//            string vName = "Deymer";
//            string vLastName = "Perea";

//            //Act
//            string vResult = vCli.CreateFullName(vName, vLastName);

//            Assert.Multiple(() =>
//            {
//                //Assert
//                Assert.AreEqual("Deymer Perea", vResult);
//                Assert.Throws(vResult, Is.EqualTo("Deymer Perea"));
//                Assert.Throws(vResult, Does.Contain("Perea"));
//                Assert.Throws(vResult, Does.Contain("perea").IgnoreCase);
//                Assert.Throws(vResult, Does.StartWith("Deymer"));
//            });

//        }

//        [Fact]
//        public void NameClient_InputNoValue_ReturnNull()
//        {
//            //Arrange

//            //Act

//            //Assert
//            Assert.IsNull(vCli.NameClient);
//        }

//        [Fact]
//        public void Discount_Evaluate_InputNoValue_ReturnIntervalDiscount()
//        {
//            //Arrange

//            //Act

//            //Assert
//            Assert.Throws(vCli.Discount, Is.InRange(5,10));
//        }

//        [Fact]
//        public void NameClient_InputNoName_ReturnNotNull()
//        {
//            //Arrange
//            string vName = "Deymer";
//            string vLastName = "";

//            //Act
//            vCli.CreateFullName(vName, vLastName);

//            //Assert
//            Assert.IsNotNull(vCli.NameClient);
//        }

//        [Fact]
//        public void NameClient_InputNoName_ReturnException()
//        {
//            //Arrange
//            string vName = "";
//            string vLastName = "Perea";

//            //Act

//            //Assert
//            var messageException = Assert.Throws<ArgumentException>(() => vCli.CreateFullName(vName, vLastName));
//            Assert.Throws(messageException.Message, Is.EqualTo("The name is not empty"));

//            Assert.Throws(() => vCli.CreateFullName(vName, vLastName), Throws.ArgumentException.With.Message.EqualTo("The name is not empty"));

//            Assert.Throws(() => vCli.CreateFullName(vName, vLastName), Throws.ArgumentException);
//        }

//        [Fact]
//        public void GetDeltailClient_CreateClientWithLessThan500TotalOrder_ReturBasicClient()
//        {
//            vCli.OrderTotal = 150;
//            var vResponse = vCli.GetDeltailClient();
//            Assert.Throws(vResponse, Is.TypeOf<ClientBasic>());
//        }

//        [Fact]
//        public void GetDeltailClient_CreateClientWithMoreThan500TotalOrder_ReturBasicClient()
//        {
//            vCli.OrderTotal = 550;
//            var vResponse = vCli.GetDeltailClient();
//            Assert.Throws(vResponse, Is.TypeOf<ClientPremiun>());
//        }


//    }
//}
