using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Permutation
{
    public class Perm
    {
        public long Permutation(int n, int r)
        {
            if (n == 0)
                return 1;

            var diff = 0;
            long result = 1;
            
            while (r > diff)
            {
                result = result * (n - diff);
                diff++;
            }
            
            return result;
        }
    }
}
