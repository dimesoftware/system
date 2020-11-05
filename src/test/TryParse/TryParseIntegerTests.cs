using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class TryParseIntegerTests
    {
        [TestMethod]
        public void TryParse_Int_ValidString_ShouldParse()
        {
            string number = "15";
            Assert.IsTrue(number.TryParseInt() == 15);
        }

        [TestMethod]
        public void TryParse_Int_Empty_ShouldReturnZero()
        {
            string number = string.Empty;
            Assert.IsTrue(number.TryParseInt() == 0);
        }

        [TestMethod]
        public void TryParse_Int_Null_ShouldReturnZero()
        {
            string number = null;
            Assert.IsTrue(number.TryParseInt() == 0);
        }

        [TestMethod]
        public void TryParse_Int_InvalidString_ShouldReturnZero()
        {
            string number = "fifteen";
            Assert.IsTrue(number.TryParseInt() == 0);
        }

        [TestMethod]
        public void ToNullable_Int_InvalidString_ShouldReturnNull()
        {
            string number = "fifteen";
            Assert.IsTrue(number.ToNullableInt() == null);
        }

        [TestMethod]
        public void ToNullable_Int_Null_ShouldReturnNull()
        {
            string number = null;
            Assert.IsTrue(number.ToNullableInt() == null);
        }
    }
}