/*
    Implement an algorithm to determine if a string has all unique characters. 
    What if you cannot use additional data structures
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.C1
{
    public class One
    {
        public bool Solution(string str) {
            
            var hashChar = new HashSet<char>();

            foreach (char c in str) {
                if (hashChar.Contains(c)) return false;
                hashChar.Add(c);
            }

            return true;
        }
    }
}
