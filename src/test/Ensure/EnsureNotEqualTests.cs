using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureNotEqualTests
    {
        [TestMethod]
        public void Ensure_NotEqual_ValuesAreNotEqual_ShouldNotThrowException()
            => Ensure.NotEqual(1,2);

        [TestMethod]
        public void Ensure_NotEqual_ValuesAreEqual_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.NotEqual(1, 1));
    }
}