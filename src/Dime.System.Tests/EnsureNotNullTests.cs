using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureNotNullTests
    {
        [TestMethod]
        public void Ensure_NotNull_ConditionIsTrue_ShouldThrowException()
            => Assert.ThrowsException<NullReferenceException>(() => Ensure.NotNull(null, "Items must be equal"),
                "Items must be equal");
      
        [TestMethod]
        public void Ensure_NotNull_ConditionIsFalse_ShouldNotThrowException()
            => Ensure.NotNull(new object(), "Items must be equal");     
    }
}
