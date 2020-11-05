using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureArgumentTests
    {
        [TestMethod]
        public void Ensure_Argument_NotNull_ConditionIsTrue_ShouldNotThrowException()
            => Ensure.Argument.NotNull("", "parameter1");

        [TestMethod]
        public void Ensure_Argument_NotNull_ConditionIsFalse_ShouldThrowException()
            => Assert.ThrowsException<ArgumentNullException>(() => Ensure.Argument.NotNullOrEmpty(null, "parameter1"));

        [TestMethod]
        public void Ensure_Argument_NotNullOrEmpty_IsEmpty_ShouldThrowException()
            => Assert.ThrowsException<ArgumentException>(() => Ensure.Argument.NotNullOrEmpty("", "parameter1"));

        [TestMethod]
        public void Ensure_Argument_NotNullOrEmpty_IsNull_ShouldThrowException()
            => Assert.ThrowsException<ArgumentNullException>(() => Ensure.Argument.NotNullOrEmpty(null, "parameter1"));

        [TestMethod]
        public void Ensure_Argument_NotNullOrEmpty_IsNotNull_ShouldNotThrowException()
            => Ensure.Argument.NotNullOrEmpty("Hello world", "parameter1");

        [TestMethod]
        public void Ensure_Argument_IsNot_ConditionIsFalse_ShouldNotThrowException()
            => Ensure.Argument.IsNot(5 == 2, "Exception message");

        [TestMethod]
        public void Ensure_Argument_IsNot_ConditionIsTrue_ShouldThrowException()
            => Assert.ThrowsException<ArgumentException>(() => Ensure.Argument.IsNot(2 == 2, "Exception message"));

        [TestMethod]
        public void Ensure_Argument_Is_ConditionIsFalse_ShouldThrowException()
            => Assert.ThrowsException<ArgumentException>(() => Ensure.Argument.Is(5 == 2, "Exception message"));

        [TestMethod]
        public void Ensure_Argument_Is_ConditionIsTrue_ShouldNotThrowException()
            => Ensure.Argument.Is(2 == 2, "Exception message");
    }
}