using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
	//	https://codility.com/demo/take-sample-test/count_div
	//	Correctness: 100% performance: 00% Score:50% Duration: 30 min
	public class CountDiv
	{
		int count = 0;
		
		public int solution(int A, int B, int K) {
			
			getCount(A,B,K);

			return count;
		}

		public void getCount(int a, int b, int k)
		{
			if (a <= b)
			{
				if (a%k == 0)
				{
					count++;					
				}

				a++;
				getCount(a, b, k);
			}			
		}

	}
}
