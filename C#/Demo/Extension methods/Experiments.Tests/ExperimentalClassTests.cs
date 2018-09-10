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
            Assert.IsTrue("".IsNullOrEmpty());
            Assert.IsTrue(StringExtension.IsNullOrEmpty(null));
            Assert.IsFalse("abc".IsNullOrEmpty());

        }
        [TestMethod]
        public void IsDateTimeTest_EnteredStringWithDate_TrueOrFalseReturned()
        {
            Assert.IsTrue("2018.08.29.22.11.30".IsDateTime());
            Assert.IsFalse("Hello World".IsDateTime());
        }
        [TestMethod]
        public void ToDateTime_StringEntered_DateReturned()
        {
            Assert.AreEqual(new DateTime(2018, 08, 29, 13,33,33), "2018.08.29.13.33.33".ToDateTime());
        }
        [TestMethod]
        public void IsEmpty_StringEntered_TrueReturned()
        {
            Assert.IsTrue("".IsEmpty());
            Assert.IsFalse("Hello World".IsEmpty());
        }
    }
}
