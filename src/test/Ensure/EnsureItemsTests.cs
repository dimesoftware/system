using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureItemsTests
    {
        [TestMethod]
        public void Ensure_Items_PredicateIsTrue_ShouldNotThrowException()
            => Ensure.Items(new List<int> { 1, 2 }, x => x < 3);

        [TestMethod]
        public void Ensure_Items_PredicateIsFalse_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.Items(new List<int> { 1, 5 }, x => x < 3));
    }
}