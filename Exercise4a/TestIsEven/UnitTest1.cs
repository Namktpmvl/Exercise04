using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4a;

namespace TestIsEven
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsEven2(4);
            Assert.AreEqual(true, result4);
        }
    }
}
