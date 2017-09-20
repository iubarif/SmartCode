using ConsoleApp.Permutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class PermutationTest
    {
        Perm _perm;
        
        public PermutationTest()
        {
            _perm = new Perm();
        }

        [TestMethod]
        public void Permutation_Of_5p3_Should_Return_60() {
            Assert.AreEqual(_perm.Permutation(5, 3), 60);
        }

        [TestMethod]
        public void Permutation_Of_5p5_Should_Return_120()
        {
            Assert.AreEqual(_perm.Permutation(5, 5), 120);
        }

        [TestMethod]
        public void Permutation_Of_6p3_Should_Return_120()
        {
            Assert.AreEqual(_perm.Permutation(6, 3), 120);
        }

        [TestMethod]
        public void Permutation_Of_26p3_Should_Return_15600()
        {
            Assert.AreEqual(_perm.Permutation(26, 3), 15600);
        }

        [TestMethod]
        public void Permutation_Of_0p0_Should_Return_1()
        {
            Assert.AreEqual(_perm.Permutation(0, 0), 1);
        }

        [TestMethod]
        public void Permutation_Of_100p5_Should_Return_9034502400()
        {
            Assert.AreEqual(_perm.Permutation(100, 5), 9034502400);
        }

        [TestMethod]
        public void Permutation_Of_4p4_Should_Return_24()
        {
            Assert.AreEqual(_perm.Permutation(4, 4), 24);
        }
    }
}
