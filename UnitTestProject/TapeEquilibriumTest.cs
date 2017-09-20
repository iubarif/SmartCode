using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
    [TestClass]
    public class TapeEquilibriumTest
    {
        TapeEquilibrium _te; 

        public TapeEquilibriumTest()
        {
            _te = new TapeEquilibrium();
        }

        [TestMethod]
        public void TapeEquilibriumTest_Given_return_1()
        {
            int[] A = { 3,1,2,4,3};

            Assert.AreEqual(_te.solution(A), 1);
        }

        [TestMethod]
        public void TapeEquilibriumTest_Big_return_1()
        {
            int[] A = { 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3, 3, 1, 2, 4, 3 };

            Assert.AreEqual(_te.solution(A), 1);
        }        
    }
}
