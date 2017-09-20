using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
	[TestClass]
	public class MissingIntegerTest
	{
		MissingInteger _mInt;

		public MissingIntegerTest()
		{
			_mInt = new MissingInteger();
		}

		[TestMethod]
		public void MissingIntegerTest_136412_Returns_5()
		{
			int[] A = { 1, 3, 6, 4, 1, 2 };
			Assert.AreEqual(_mInt.solution(A), 5);
		}

		[TestMethod]
		public void MissingIntegerTest_123_Returns_4()
		{
			int[] A = { 1, 2, 3 };
			Assert.AreEqual(_mInt.solution(A), 4);
		}

		[TestMethod]
		public void MissingIntegerTest_1_Returns_2()
		{
			int[] A = { 1 };
			Assert.AreEqual(_mInt.solution(A), 2);
		}

		[TestMethod]
		public void MissingIntegerTest_2_Returns_1()
		{
			int[] A = { 2 };
			Assert.AreEqual(_mInt.solution(A), 1);
		}

		[TestMethod]
		public void MissingIntegerTest_Missing_Returns_1()
		{
			int[] A = { };
			Assert.AreEqual(_mInt.solution(A), 1);
		}
		
	}
}
