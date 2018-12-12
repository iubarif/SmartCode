using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.TopTal;

namespace UnitTestProject.TopTal
{
    [TestClass]
    public class Problem_03Test
    {
        Problem3 _p3;

        public Problem_03Test()
        {
            _p3 = new Problem3();
        }

        [TestMethod]
        public void Problem_03_Test()
        {
            int[] A = { };

            Assert.AreEqual(_p3.solution(A), 0);
        }
    }
}
