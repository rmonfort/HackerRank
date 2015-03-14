/*
 * https://www.hackerrank.com/challenges/pangrams
 */

using System;
using System.Linq;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            // Test if sentence is pangram and output results
            string result = IsPangram(sentence) ? "pangram" : "not pangram"; 
            Console.WriteLine(result);
        }

        // Returns true if given sentence is pangram
        private static bool IsPangram(string sentence)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(sentence.ToLower().Contains);
        }
    }
}
