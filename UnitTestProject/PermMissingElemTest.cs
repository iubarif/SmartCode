using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
    [TestClass]
    public class PermMissingElemTest
    {
        PermMissingElem _pme;

        public PermMissingElemTest()
        {
            _pme = new PermMissingElem();
        }

        [TestMethod]
        public void PermMissingElemTest_2_3_1_5_Returns4()
        {
            int[] A = { 2, 3, 1, 5 };

            Assert.AreEqual(_pme.solution(A), 4);
        }

        [TestMethod]
        public void PermMissingElemTest_Empty_Returns1()
        {
            int[] A = { };

            Assert.AreEqual(_pme.solution(A), 1);
        }

        [TestMethod]
        public void PermMissingElemTest_Single_Returns2()
        {
            int[] A = { 1 };

            Assert.AreEqual(_pme.solution(A), 2);
        }

        [TestMethod]
        public void PermMissingElemTest_FirstMissing_Returns1()
        {
            int[] A = { 2,3,4 };

            Assert.AreEqual(_pme.solution(A), 1);
        }

        [TestMethod]
        public void PermMissingElemTest_LastMissing_Returns4()
        {
            int[] A = { 1, 2, 3 };

            Assert.AreEqual(_pme.solution(A), 4);
        }

        [TestMethod]
        public void PermMissingElemTest_Single_First_Missing_Returns1()
        {
            int[] A = { 2 };

            Assert.AreEqual(_pme.solution(A), 1);
        }

    }
}
