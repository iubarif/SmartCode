using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
    //  https://codility.com/demo/take-sample-test/perm_missing_elem
    //  Correctness: 100% performance: 40% Score:70%

    public class PermMissingElem
    {
        public int solution(int[] A) {
            
            var aLength = A.Length;

            // Because one element is missing
            float lengthShouldBe = aLength + 1;

            var sumOfSeriesShouldBe = ((1 + lengthShouldBe) / 2) * lengthShouldBe;
            var sumReal = A.Sum();

            var missingVal = Convert.ToInt32(sumOfSeriesShouldBe) - sumReal;
            return missingVal > 0 ? missingVal : 1;
        }
    }
}
