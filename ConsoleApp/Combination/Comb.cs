using ConsoleApp.Permutation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Combination
{
    public class Comb
    {
        public long Combination(int n, int r) {

            Perm p = new Perm();

            return p.Permutation(n, r) / p.Permutation(r, r);            
        }
    }
}
