using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Main
    {
        [TestMethod]
        public void Add()
        {
            int a = 5;
            int b = 7;
            int result = a + b;
            Assert.AreEqual(12, result);
        }
    }
}
