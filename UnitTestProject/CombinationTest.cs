using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Combination;

namespace UnitTestProject
{
    [TestClass]
    public class CombinationTest
    {
        Comb _c; 

        public CombinationTest()
        {
            _c = new Comb();
        }

        [TestMethod]
        public void Combination_Of_5c5_Should_Return_1()
        {
            Assert.AreEqual(_c.Combination(5, 5), 1);
        }

        [TestMethod]
        public void Combination_Of_5c3_Should_Return_10()
        {
            Assert.AreEqual(_c.Combination(5, 3), 10);
        }

        [TestMethod]
        public void Combination_Of_0c0_Should_Return_1()
        {
            Assert.AreEqual(_c.Combination(0, 0), 1);
        }

        [TestMethod]
        public void Combination_Of_6c4_Should_Return_15()
        {
            Assert.AreEqual(_c.Combination(6, 4), 15);
        }

        [TestMethod]
        public void Combination_Of_36c9_Should_Return_94143280()
        {
            Assert.AreEqual(_c.Combination(36, 9), 94143280);
        }
    }
}
