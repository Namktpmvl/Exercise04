using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4a;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd2(4);
            Assert.AreEqual(false, result4);
        }
    }
}
