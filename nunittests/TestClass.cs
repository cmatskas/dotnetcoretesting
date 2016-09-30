using System;
using NUnit.Framework;

namespace MyMsUnitTests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void ThisShouldSucceed()
        {
            Assert.IsTrue(true);    
        }

        [Test]
        public void ThisShouldFail()
        {
            Assert.IsFalse(true);
        }
    }
}
