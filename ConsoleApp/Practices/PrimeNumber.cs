using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
    public class PrimeNumber
    {
        public bool IsPrime(long num) {

            var returnVal = true;

            if (num <= 1)
                return true;

            for (int i = 2; i < num; i++) {
                if (num % i == 0) {
                    returnVal = false;
                    break;
                }
            }

            return returnVal;
        }

        public void GeneratePrimeNumbers(int size) {
        }    
    }
}
