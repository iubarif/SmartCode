using ConsoleApp.Practices;
using ConsoleApp.TopTal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Problem3 p3 = new Problem3();

            Console.WriteLine(p3.solution(123, 456));
            Console.WriteLine(p3.solution(555, 555));
            Console.WriteLine(p3.solution(900, 11));
            Console.WriteLine(p3.solution(145, 55));
            Console.WriteLine(p3.solution(0, 0));

            Console.WriteLine(p3.solution(1, 99999));
            Console.WriteLine(p3.solution(999045, 1055));
            Console.WriteLine(p3.solution(101, 809));
            





        }
    }
}
