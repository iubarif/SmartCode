using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.TopTal;

namespace UnitTestProject.TopTal
{
    [TestClass]
    public class Problem_01Test
    {
        Problem1 _p1;

        public Problem_01Test()
        {
            _p1 = new Problem1();
        }

        [TestMethod]
        public void Problem_01_Test()
        {
            int[] A = { };

            Assert.AreEqual(_p1.solution(A), 0);
        }
    }
}
