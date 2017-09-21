using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
	public class PassingCars
	{
		public int solution(int[] A) {

			//int j = 0;
			int pair = 0;

			for (int i = 0; i < A.Length; i++)
			{

				//if (A[i] != 3)
				//{
				for (int j = i + 1; i < A.Length; i++)
				{
					if (A[i] != A[j])
					{
						pair++;
						A[j] = 3;
					}

				}
				//}

			}
			

			return 0;
		}


		
	}
}
