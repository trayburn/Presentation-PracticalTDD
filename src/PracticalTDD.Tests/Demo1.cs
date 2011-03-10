using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticalTDD.Tests.MathFixture
{
    /*
     * Demonstration of Given/When/Then style tests.
     */
    [TestClass]
    public class Given_Two_Integers
    {
        int a;
        int b;

        [TestInitialize]
        public void When_Both_Integers_Are_Odd()
        {
            a = 1;
            b = 13;
        }

        [TestMethod]
        public void Then_Addition_Should_Result_In_An_Even()
        {
            var r = a + b;
            Assert.AreEqual(0, r % 2);
        }
    }
}
