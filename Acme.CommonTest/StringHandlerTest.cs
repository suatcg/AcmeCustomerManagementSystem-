using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            // Act
            //var actual = handler.InsertSpace(source);
            //var actual = StringHandler.InsertSpace(source);
            var actual = source.InsertSpace();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestsWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            // Act
            //var actual = handler.InsertSpace(source);
            //var actual = StringHandler.InsertSpace(source);
            var actual = source.InsertSpace();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
