using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureContainsTests
    {
        [TestMethod]
        public void Ensure_Contains_PredicateReturnsTrue_ShouldNotThrowException()
            => Ensure.Contains(new List<int> { 1, 2 }, x => x == 2);

        [TestMethod]
        public void Ensure_Contains_PredicateReturnsFalse_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.Contains(new List<int> { 1, 2 }, x => x == 3));
    }
}