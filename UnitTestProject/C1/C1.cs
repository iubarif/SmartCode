using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.C1
{
    [TestClass]
    public class C1
    {
        [TestMethod]
        public void Solution_for_Problem_One()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            List<bool> results = new List<bool>();
            
            var one = new ConsoleApp.C1.One();
            foreach (string word in words)
            {
                results.Add(one.Solution(word));                
            }

            CollectionAssert.AreEqual(results, new List<bool> { true, false, false, true, true });

        }

        [TestMethod]
        public void Solution_for_Problem_Two()
        {
            string[][] wordPair = {
                new string[]{ "apple", "papel" },
                new string[]{ "carrot", "tarroc" },
                new string[]{ "hello", "llloh" }
            };

            List<bool> results = new List<bool>();

            var two = new ConsoleApp.C1.Two();
            foreach (var words in wordPair)
            {
                results.Add(two.Solution(words[0], words[1]));
            }

            CollectionAssert.AreEqual(results, new List<bool> { true, true, false});

        }

        [TestMethod]
        public void Solution_for_Problem_Three()
        {
            string[] words = { "my name is John   ", "hello   world", "  apple pie  "};

            List<string> results = new List<string>();

            var three = new ConsoleApp.C1.Three();

            foreach (var word in words)
            {
                results.Add(three.Solution(word));
            }

            // %20
            CollectionAssert.AreEqual(results, new List<string> { "my%20name%20is%20John", "hello%20world", "apple%20pie" });

        }
    }
}
