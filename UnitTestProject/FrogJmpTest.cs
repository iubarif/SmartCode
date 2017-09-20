using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for FrogJmpTest
    /// </summary>
    [TestClass]
    public class FrogJmpTest
    {
        FrogJmp _frgJmp;

        public FrogJmpTest()
        {
            _frgJmp = new FrogJmp();
        }
        
        [TestMethod]
        public void FrogJmpTest_X10_Y85_D30_Returns_3()
        {
            Assert.AreEqual(_frgJmp.JumpCount(10, 85, 30), 3);
        }

        [TestMethod]
        public void FrogJmpTest_X100000_Y850000_D300000_Returns_3()
        {
            Assert.AreEqual(_frgJmp.JumpCount(10, 85, 30), 3);
        }
    }
}
