using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class TryParseLongTests
    {
        [TestMethod]
        public void TryParse_Long_ValidString_ShouldParse()
        {
            string number = "15";
            Assert.IsTrue(number.TryParseLong() == 15);
        }

        [TestMethod]
        public void TryParse_Long_Empty_ShouldReturnZero()
        {
            string number = string.Empty;
            Assert.IsTrue(number.TryParseLong() == 0);
        }

        [TestMethod]
        public void TryParse_Long_Null_ShouldReturnZero()
        {
            string number = null;
            Assert.IsTrue(number.TryParseLong() == 0);
        }

        [TestMethod]
        public void TryParse_Long_InvalidString_ShouldReturnZero()
        {
            string number = "fifteen";
            Assert.IsTrue(number.TryParseLong() == 0);
        }

        [TestMethod]
        public void ToNullable_Long_InvalidString_ShouldReturnNull()
        {
            string number = "fifteen";
            Assert.IsTrue(number.ToNullableLong() == null);
        }

        [TestMethod]
        public void ToNullable_Long_Null_ShouldReturnNull()
        {
            string number = null;
            Assert.IsTrue(number.ToNullableLong() == null);
        }
    }
}