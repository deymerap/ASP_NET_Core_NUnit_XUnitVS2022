using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    [TestFixture]
    public class ClienteNUnitTest
    {
        private Cliente vCli;
        [SetUp]
        public void ini()
        {
            vCli = new Cliente();
        }    


        [Test]
        public void CreateFullName_InputNameLastName_ReturnFullName()
        {
            //Arrange
            string vName = "Deymer";
            string vLastName = "Perea";

            //Act
            string vResult = vCli.CreateFullName(vName, vLastName);

            Assert.Multiple(() =>
            {
                //Assert
                Assert.AreEqual("Deymer Perea", vResult);
                Assert.That(vResult, Is.EqualTo("Deymer Perea"));
                Assert.That(vResult, Does.Contain("Perea"));
                Assert.That(vResult, Does.Contain("perea").IgnoreCase);
                Assert.That(vResult, Does.StartWith("Deymer"));
            });

        }

        [Test]
        public void NameClient_InputNoValue_ReturnNull()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsNull(vCli.NameClient);
        }

        [Test]
        public void Discount_Evaluate_InputNoValue_ReturnIntervalDiscount()
        {
            //Arrange

            //Act

            //Assert
            Assert.That(vCli.Discount, Is.InRange(5,10));
        }

        [Test]
        public void NameClient_InputNoName_ReturnNotNull()
        {
            //Arrange
            string vName = "Deymer";
            string vLastName = "";

            //Act
            vCli.CreateFullName(vName, vLastName);

            //Assert
            Assert.IsNotNull(vCli.NameClient);
        }

        [Test]
        public void NameClient_InputNoName_ReturnException()
        {
            //Arrange
            string vName = "";
            string vLastName = "Perea";

            //Act

            //Assert
            var messageException = Assert.Throws<ArgumentException>(() => vCli.CreateFullName(vName, vLastName));
            Assert.That(messageException.Message, Is.EqualTo("The name is not empty"));

            Assert.That(() => vCli.CreateFullName(vName, vLastName), Throws.ArgumentException.With.Message.EqualTo("The name is not empty"));

            Assert.That(() => vCli.CreateFullName(vName, vLastName), Throws.ArgumentException);
        }

        [Test]
        public void GetDeltailClient_CreateClientWithLessThan500TotalOrder_ReturBasicClient()
        {
            vCli.OrderTotal = 150;
            var vResponse = vCli.GetDeltailClient();
            Assert.That(vResponse, Is.TypeOf<ClientBasic>());
        }

        [Test]
        public void GetDeltailClient_CreateClientWithMoreThan500TotalOrder_ReturBasicClient()
        {
            vCli.OrderTotal = 550;
            var vResponse = vCli.GetDeltailClient();
            Assert.That(vResponse, Is.TypeOf<ClientPremiun>());
        }


    }
}
