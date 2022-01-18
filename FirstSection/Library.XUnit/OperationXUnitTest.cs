using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryDpm
{
    public class OperationXUnitTest
    {
        [Fact]
        public void Sum_ImputTowNumbers_GetCorrectValue()
        {
            //Arrange
            Operation operation1 = new();
            int vNumber1Test = 50;
            int vNumber2Test = 50;

            //Act
            int vResult = operation1.Sum(vNumber1Test, vNumber2Test);

            //Assert
            Assert.Equal(100, vResult);
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(1)]
        public void IsValueEven_InputOneNumberEven_ReturnFalse(int vNumber)
        {
            //Arrange
            Operation operation = new();
            
            //Act
            bool responser =  operation.IsValueEven(vNumber);

            //Assert
            //Assert.IsFalse(responser);
            Assert.False(responser);
        }

        [Theory]
        [InlineData(3, true)]
        [InlineData(1, true)]
        public void IsValueEven_InputOneNumberEven_ReturnTrue(int vNumber, bool vExpectedResult)
        {
            //Arrange
            Operation operation = new();

            //Act
            bool responser = !operation.IsValueEven(vNumber);

            Assert.Equal(vExpectedResult, responser);
        }


        [Theory]
        [InlineData(2.2,1.2)]
        [InlineData(2.23, 1.24)]
        public void SumDecimal_ImputTowNumbers_GetCorrectValue(double vNumber1Test, double vNumber2Test)
        {
            //Arrange
            Operation operation = new();

            //Act
            double vResult = operation.SumDecimal(vNumber1Test, vNumber2Test);

            //Assert
            Assert.Equal(3.4, vResult,0);
        }

        [Fact]
        public void ListOddNumbers_inputMinMaxInterval_ReturnListOddNumbers()
        {
            Operation operation = new();
            List<int> listCompare = new List<int>() { 5, 7 , 9 };

            List<int> vListResponse = operation.ListOddNumbers(5,10);

            Assert.Equal(listCompare, vListResponse);
            Assert.Contains(5, vListResponse);

            //CollectionAssert.AreEqual(listCompare, vListResponse);
            //CollectionAssert.AreEquivalent(listCompare, vListResponse);

            Assert.Equal(listCompare.Count, vListResponse.Count);
            Assert.DoesNotContain(10, vListResponse);
            Assert.Equal(vListResponse.OrderBy(x => x), vListResponse);
        }

    }
}
