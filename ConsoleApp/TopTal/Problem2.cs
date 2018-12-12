using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TopTal
{
    public class Problem2
    {
        public int solution(int[] A, int D)
        {

            int i = 1;
            int N = A.Length;
            int count = -1;
            while (i < N) {                
                if (A[i + D] > -1)
                {
                    count++;
                    i += D;
                }
                else {
                    i--;                
                }                
            }

            return count;
        }
    }
}
