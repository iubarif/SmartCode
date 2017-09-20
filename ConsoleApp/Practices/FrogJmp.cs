using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
    //  Problem: https://codility.com/demo/take-sample-test/frog_jmp
    //  Correctness     Performance     Task score
    //  100%	        100%	        100%	

    public class FrogJmp
    {
        public long JumpCount(int X, int Y, int D) {

            decimal jumpCount =  (Convert.ToDecimal(Y) - Convert.ToDecimal(X)) / Convert.ToDecimal(D);

            return Convert.ToInt64(Math.Ceiling(jumpCount))  ;
        }
    }

    
}
