using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
    [TestClass]
    public class ArrayShiftTest
    {
        ArrayShift _as;

        public ArrayShiftTest()
        {
            _as = new ArrayShift();
        }

        [TestMethod]
        public void ArrayShiftTest_abc_Shift1_returns_cab()
        {
            string[] A = { "a", "b", "c" };
            string[] R = { "c", "a", "b" };

            var x = _as.solution(A, 1);

            CollectionAssert.AreEquivalent(_as.solution(A, 1), R);
        }

        [TestMethod]
        public void ArrayShiftTest_abc_Shift2_returns_bca()
        {
            string[] A = { "a", "b", "c" };
            string[] R = { "b", "c", "a" };

            CollectionAssert.AreEquivalent(_as.solution(A, 1), R);
        }

        [TestMethod]
        public void ArrayShiftTest_abc_Shift3_returns_abc()
        {
            string[] A = { "a", "b", "c" };
            string[] R = { "a", "b", "c" };

            CollectionAssert.AreEquivalent(_as.solution(A, 1), R);
        }

        [TestMethod]
        public void ArrayShiftTest_abcde_Shift3_returns_cdeab()
        {
            string[] A = { "a", "b", "c","d","e" };
            string[] R = { "c", "d", "e", "a", "b" };

            CollectionAssert.AreEquivalent(_as.solution(A, 1), R);
        }
    }
}
