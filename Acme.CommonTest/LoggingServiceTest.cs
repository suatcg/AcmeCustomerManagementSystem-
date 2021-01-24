using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changeItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAdress = "fbaggind@hobbiton.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changeItems.Add(customer);

            var prodcut = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Take With Stell Head",
                CurrentPrice = 6M
            };
            changeItems.Add(prodcut);

            // Act
            LoggingService.WriteToFile(changeItems);

            // Assert
            // Nothing here asserted look toward to the output of the test 
        }
    }
}
