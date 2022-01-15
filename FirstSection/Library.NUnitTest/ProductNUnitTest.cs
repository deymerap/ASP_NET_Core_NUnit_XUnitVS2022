using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace LibraryDpm
{
    [TestFixture]
    public class ProductNUnitTest
    {
        [Test]
        public void GetPrice_PremiumClient_ReturnPrice80Percent()
        {
            Product product = new Product { Id = 1, Name = "Name product", Price = 50 };

            var vResultPrice = product.GetPrice(new Cliente { IsPremium = true });
            Assert.That(vResultPrice, Is.EqualTo(product.Price * 0.8));
        }


        public void GetPrice_PremiumClientMocking_ReturnPrice80Percent()
        {
            Product product = new Product { Id = 1, Name = "Name product", Price = 50 };

            var mockClient = new Mock<ICliente>();
            mockClient.Setup(x => x.IsPremium).Returns(true);
            
            var vResultPrice = product.GetPrice(mockClient.Object);
            Assert.That(vResultPrice, Is.EqualTo(40));
        }

    }
}
