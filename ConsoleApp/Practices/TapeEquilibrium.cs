using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
    //  https://codility.com/demo/take-sample-test/tape_equilibrium
    //  Correctness: 100% performance: 100% Score:100% Duration: 30 min

    public class TapeEquilibrium
    {
        public int solution(int[] A) {

            var len = A.Length;

            var part1 = A[0];
            var part2 = A.Sum()-part1;
            var minLen = Math.Abs(part1- part2);

            for (int i = 1; i < len-1; i++) {
                part1 += A[i];
                part2 -= A[i];

                var diff = Math.Abs(part1 - part2);
                if (diff < minLen) {
                    minLen = diff;
                    if (minLen == 0)
                        break;
                }
            }


            return minLen;
        }
    }
}
