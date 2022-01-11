using LibraryDpm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MSTest.Test
{
    [TestClass]
    public class OperationMSTest
    {
        [TestMethod]
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

    }
}
