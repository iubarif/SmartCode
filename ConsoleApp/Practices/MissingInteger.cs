using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
	//  https://codility.com/demo/take-sample-test/missing_integer
	//  Correctness: 100% performance: 100% Score:100% Duration: 30 min

	public class MissingInteger
	{
		public int solution(int[] A) {

			if (A.Length == 0)
				return 1;

			Array.Sort(A);
			int prv = 0;

			for (int i = 0; i < A.Length; i++) {
				if (A[i] > 0)
				{
					int val = A[i] - prv;

					if (val > 1)
						return prv + 1;
					else
						prv = A[i];

				}
			}
			
			return prv + 1;
		}
	}
}
