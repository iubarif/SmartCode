using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practices
{
    public class ArrayShift
    {
        public string[] solution(string[] A, int shift) {
            int N = A.Length;

            // Store lastNumber and shift everything by 1 . at the end set the fist element = lastNumber

            for (int p = 0; p < shift - 1; p++)
            {
                var lst = A[N - 1];

                for (int i = N - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        A[i] = lst;
                    }
                    else
                    {
                        A[i] = A[i - 1];
                    }

                }
            }

            return A;
        }
    }
}
