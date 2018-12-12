using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp.C1
{
    public class Three
    {
        public string Solution(string str) {

            // Trim strat and end spaces
            str = str.Trim();

            return Regex.Replace(str, @"\s+", "%20");            
        }
    }
}
