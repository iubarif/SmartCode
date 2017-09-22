using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
	public class MinAvgTwoSlice
	{
		public int solution(int[] A) {

			int N = A.Length;
			int fst = A[0];
			decimal sliceAvg = (Convert.ToDecimal(A[0])+ Convert.ToDecimal(A[1]))/2m;
			int stPos = 0;

			


			for (int j = 0; j < N - 1; j++)
			{
				var k = j;
				decimal s = 0;

				for (int i = j+1; i < N ; i++)
				{

					if (k < i + 1)
					{
						if (k == 0)
						{
							s = fst;
						}
						else
						{
							s += A[k];

							decimal sliceSumAvg = s / (Convert.ToDecimal(i) + 1m);

							if (sliceSumAvg <= sliceAvg)
							{
								sliceAvg = sliceSumAvg;
								stPos = j;
							}
						}

						k++;
					}

				}
			}

			return stPos;
		}
	}
}
