using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperimentsLib;

namespace Experiments.Tests
{
    [TestClass]
    public class ExperimentalClassTests
    {
        [TestMethod]
        public void IsNullOrEmpty_Hello_World_returned_true()
        {

           // Assert
            Assert.IsTrue("".IsNullOrEmpty());
            Assert.IsTrue(StringExtension.IsNullOrEmpty(null));
            Assert.IsFalse("abc".IsNullOrEmpty());

        }
        [TestMethod]
        public void IsDateTimeTest_EnteredStringWithDate_TrueOrFalseReturned()
        {
            // Arrange
            String str = "2018.08.29.22.11.30";
            String str1 = "Hello World";
            // Assert
            Assert.IsTrue(str.IsDateTime());
            Assert.IsFalse(str1.IsDateTime());
        }
        [TestMethod]
        public void ToDateTime_StringEntered_DateReturned()
        {
            // Arrange
            String str = "2018.08.29.22.11.30";
            DateTime expectedDate = new DateTime(2018, 08, 29, 22, 11, 30);
            // Act 
            DateTime actualDate = new DateTime();
            actualDate = str.ToDateTime();
            // Assert
            Assert.AreEqual(expectedDate, actualDate);
        }
        [TestMethod]
        public void IsEmpty_StringEntered_TrueReturned()
        {
            // Assert
            Assert.IsTrue("Hello World".IsEmpty());
        }
    }
}
