using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureNotNullOrEmptyTests
    {
        [TestMethod]
        public void Ensure_NotNullOrEmpty_ConditionIsTrue_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.NotNullOrEmpty(null, "Items must be equal"), "Items must be equal");

        [TestMethod]
        public void Ensure_NotNullOrEmpty_ConditionIsTrue_NoMessage_ShouldThrowException_WithDefaultMessage()
            => Assert.ThrowsException<Exception>(() => Ensure.NotNullOrEmpty(string.Empty),
                "String cannot be null or empty");

        [TestMethod]
        public void Ensure_NotNullOrEmpty_ConditionIsFalse_ShouldNotThrowException()
            => Ensure.NotNullOrEmpty("Hello world", "Items must be equal");
    }
}
