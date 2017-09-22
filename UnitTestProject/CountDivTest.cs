using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Practices;

namespace UnitTestProject
{
	[TestClass]
	public class CountDivTest
	{
		CountDiv _cd;

		public CountDivTest()
		{
			_cd = new CountDiv();
		}

		[TestMethod]
		public void CountDivTest_6_11_2_Returns_3()
		{
			Assert.AreEqual(_cd.solution(6, 11, 2), 3);
		}

		[TestMethod]
		public void CountDivTest_11_345_17_Returns_20()
		{
			Assert.AreEqual(_cd.solution(11, 345, 17), 20);
		}		
	}
}
