using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureNotTests
    {       
        [TestMethod]
        public void Ensure_Not_ConditionAndMessage_ConditionIsTrue_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.Not(1 == 1, "Items must be equal"),
                "Items must be equal");

        [TestMethod]
        public void Ensure_Not_ConditionAndMessage_ConditionIsFalse_ShouldNotThrowException()
            => Ensure.Not(1 == 2, "Items must be equal");

        [TestMethod]
        public void Ensure_Not_ConditionAndMessageAndGenericExceptionType_ConditionIsTrue_ShouldThrowException()
            => Assert.ThrowsException<ArgumentException>(() => Ensure.Not<ArgumentException>(1 == 1, "Items must be equal"),
                "Items must be equal");

        [TestMethod]
        public void Ensure_Not_ConditionAndMessageAndGenericExceptionType_ConditionIsFalse_ShouldNotThrowException()
            => Ensure.Not<ArgumentException>(1 == 2, "Items must be equal");
    }
}
