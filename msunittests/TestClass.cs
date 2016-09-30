using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;

namespace MyMsUnitTests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void ThisShouldSucceed()
        {
            Assert.IsTrue(true);    
        }

        [TestMethod]
        public void ThisShouldFail()
        {
            Assert.IsFalse(true);
        }
    }
}
