using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
    [TestClass]
    public class MaxCountersTest
    {
        MaxCounters _mCounter; 
        public MaxCountersTest()
        {
            _mCounter = new MaxCounters();
        }

        [TestMethod]
        public void MaxCountersTest_Given_Returns_32242()
        {
            int N = 5;
            int[] A = { 3,4,4,6,1,4,4};

            int[] RetVal = { 3, 2, 2, 4, 2 };

            CollectionAssert.AreEquivalent(_mCounter.solution(N, A), RetVal);
        }
    }
}
