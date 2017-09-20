using System.Linq;

namespace ConsoleApp.Practices
{
    //  https://codility.com/demo/take-sample-test/max_counters
    //  Correctness: 100% performance: 40% Score:66% Duration: 40 min

    public class MaxCounters
    {
        public int[] solution(int N, int[] A) {

            int[] counter = new int[N];
            var max = 0;

            for (int i = 0; i < A.Length; i++) {
                if (A[i] > N)
                {
                    counter = Enumerable.Repeat(max, N).ToArray();
                }
                else {
                    var couterVal = counter[A[i]-1];

                    couterVal++;

                    counter[A[i]-1] = couterVal;

                    if(couterVal> max)
                    {
                        max = couterVal;
                    }
                }
            }

            return counter;
        }
    }
}
