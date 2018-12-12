/*
 * Given two strings, write a method to decide if one is a permutation of the other.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.C1
{
    public class Two
    {
        public bool Solution(string word1, string word2) {           
            // 1. char count if w1.len != w2.len return false
            if (word1.Length != word2.Length)
                return false;

            // store w1 in a hash set and compare each char of w2 if at any stage no match found returnfalse
            var sdhWord1 = DictionaryString(word1);
            var sdhWord2 = DictionaryString(word2);

            foreach (var kv in sdhWord2) {
                if (sdhWord1[kv.Key] != sdhWord2[kv.Key])
                    return false;
            } 

            return true;
        }

        private SortedDictionary<char, int> DictionaryString(string word) {
            var wordDictionary = new SortedDictionary<char,int>();

            foreach (char c in word)
            {
                if (wordDictionary.ContainsKey(c))
                    wordDictionary[c]++;
                else
                    wordDictionary.Add(c, 1);
            }

            return wordDictionary;
        }
    }
}
