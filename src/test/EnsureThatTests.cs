using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureThatTests
    {
        [TestMethod]
        public void Ensure_That_ConditionAndMessage_ConditionIsTrue_ShouldNotThrowException() 
            => Ensure.That(1 == 1, "Items must be equal");

        [TestMethod]
        public void Ensure_That_ConditionAndMessage_ConditionIsFalse_ShouldThrowException() 
            => Assert.ThrowsException<Exception>(() => Ensure.That(1 == 2, "Items must be equal"),
                "Items must be equal");

        [TestMethod]
        public void Ensure_That_ConditionAndMessageAndGenericExceptionType_ConditionIsTrue_ShouldNotThrowException() 
            => Ensure.That<InvalidOperationException>(1 == 1, "Items must be equal");

        [TestMethod]
        public void Ensure_That_ConditionAndMessageAndGenericExceptionType_ConditionIsFalse_ShouldThrowException() 
            => Assert.ThrowsException<InvalidOperationException>(
                () => Ensure.That<InvalidOperationException>(1 == 2, "Items must be equal"), "Items must be equal");
    }
}
