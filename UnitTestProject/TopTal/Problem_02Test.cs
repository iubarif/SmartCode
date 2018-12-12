using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.TopTal;

namespace UnitTestProject.TopTal
{
    [TestClass]
    public class Problem_02Test
    {
        Problem2 _p2;

        public Problem_02Test()
        {
            _p2 = new Problem2();
        }

        [TestMethod]
        public void Problem_02_Test()
        {
            int[] A = { };

            Assert.AreEqual(_p2.solution(A), 0);
        }
    }
}
