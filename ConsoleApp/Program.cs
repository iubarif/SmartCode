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
			MissingInteger p = new MissingInteger();

			int[] A = { 1, 3, 6, 4, 1, 2 };
			Console.WriteLine(p.solution(A));

			int[] B = { 1, 2, 3 };
			Console.WriteLine(p.solution(B));

			int[] C = { };
			Console.WriteLine(p.solution(C));

			int[] D = { 1 };
			Console.WriteLine(p.solution(D));

			int[] E = { 2 };
			Console.WriteLine(p.solution(E));


		}
    }
}
