using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.System.Tests
{
    [TestClass]
    public class EnsureEqualTests
    {
        [TestMethod]
        public void Ensure_Equal_ValuesAreEqual_ShouldNotThrowException()
            => Ensure.Equal(1, 1);

        [TestMethod]
        public void Ensure_Equal_ValuesAreNotEqual_ShouldThrowException()
            => Assert.ThrowsException<Exception>(() => Ensure.Equal(1, 2));
    }
}
