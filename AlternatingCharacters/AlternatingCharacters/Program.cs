/*
 * https://www.hackerrank.com/challenges/alternating-characters
 */

using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cycle through each test case
            int maxNumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < maxNumberOfTestCases; currentTestCase++)
            {
                string input = Console.ReadLine();

                // Check input for consecutive characters, and record the min number of deletions for said string to not have consecutive characters
                char prev = input[0];
                int minNumberOfDeletions = 0;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == prev)
                    {
                        minNumberOfDeletions++;
                    }
                    else
                    {
                        prev = input[i];
                    }
                }
                Console.WriteLine(minNumberOfDeletions);
            }
        }
    }
}
