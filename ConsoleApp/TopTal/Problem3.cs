using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TopTal
{
    public class Problem3
    {
        public int solution(int a, int b)
        {

            // convert to string
            var left = a.ToString().ToCharArray();
            var right = b.ToString().ToCharArray();

            var big = left.Length >= right.Length ? left : right;

            //if(big == left)
            //    b.ToString().PadLeft(left.Length-right.)


            var count = 0;
            for (int i = big.Length-1; i > -1; i--) {
                // todo : check index

                int leftVal = 0;
                int righttVal = 0;

                if (left.Length > i)
                    leftVal = int.Parse(left[i].ToString());

                if (right.Length > i)
                    righttVal = int.Parse(right[i].ToString());

                var sum = leftVal + righttVal;

                if (sum > 9)
                    count++;
            }

            return count;
        }
    }
}
