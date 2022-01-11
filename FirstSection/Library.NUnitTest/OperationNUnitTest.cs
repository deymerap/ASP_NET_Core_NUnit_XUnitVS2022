using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    [TestFixture]
    public class OperationNUnitTest
    {
        [Test]
        public void Sum_ImputTowNumbers_GetCorrectValue()
        {
            //Arrange
            Operation operation1 = new();
            int vNumber1Test = 50;
            int vNumber2Test = 50;

            //Act
            int vResult = operation1.Sum(vNumber1Test, vNumber2Test);

            //Assert
            Assert.AreEqual(100, vResult);
        }
        
        [Test]
        [TestCase(3)]
        [TestCase(1)]
        public void IsValueEven_InputOneNumberEven_ReturnFalse(int vNumber)
        {
            //Arrange
            Operation operation = new();
            
            //Act
            bool responser =  operation.IsValueEven(vNumber);

            //Assert
            //Assert.IsFalse(responser);
            Assert.That(responser, Is.False);
        }

        [Test]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = true)]
        public bool IsValueEven_InputOneNumberEven_ReturnTrue(int vNumber)
        {
            //Arrange
            Operation operation = new();

            //Act
            bool responser = !operation.IsValueEven(vNumber);
            return responser;
        }


        [Test]
        [TestCase(2.2,1.2)]
        [TestCase(2.3, 1.24)]
        public void SumDecimal_ImputTowNumbers_GetCorrectValue(double vNumber1Test, double vNumber2Test)
        {
            //Arrange
            Operation operation = new();

            //Act
            double vResult = operation.SumDecimal(vNumber1Test, vNumber2Test);

            //Assert
            Assert.AreEqual(3.4, vResult,1);
        }

        [Test]
        public void ListOddNumbers_inputMinMaxInterval_ReturnListOddNumbers()
        {
            Operation operation = new();
            List<int> listCompare = new List<int>() { 5, 7 , 9 };

            List<int> vListResponse = operation.ListOddNumbers(5,10);

            Assert.That(vListResponse, Is.EquivalentTo(listCompare));
            CollectionAssert.AreEqual(listCompare, vListResponse);
            CollectionAssert.AreEquivalent(listCompare, vListResponse);
            Assert.That(vListResponse.Count, Is.EqualTo(listCompare.Count));
            Assert.That(vListResponse, Is.Ordered.Ascending);
            Assert.That(vListResponse, Has.No.Member(10));
            Assert.That(vListResponse, Is.Unique);
        }

    }
}
