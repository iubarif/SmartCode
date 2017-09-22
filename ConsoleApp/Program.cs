using ConsoleApp.Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
			MinAvgTwoSlice ms = new MinAvgTwoSlice();

			int[] A = { 4, 2, 2, 5, 1, 5, 8 };

			var x = ms.solution(A);

		}
    }
}
