using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TopTal
{
    public class Problem1
    {


        public int solution(int[] T)
        {
            // [5 -2 3 8 6]

            int N = T.Length;
            Dictionary<int, int> winters = new Dictionary<int, int>();
            Dictionary<int, int> summers = new Dictionary<int, int>();
            
            winters.Add(0, T[0]);

            for (int i = 1; i < N; i++)
            {
                if (winters.Where(w => w.Value >= T[i]).Count() > 0)
                {
                    winters.Add(i, T[i]);

                    if (summers.Count() > 0) {
                        foreach (var e in summers) {
                            winters.Add(e.Key,e.Value);
                        }

                        summers.Clear();
                    }
                }
                else {
                    summers.Add(i, T[i]);
                }
            }

            // from rest of the number 

            return winters.Count();
        }
    }
}
