/*
 * https://www.hackerrank.com/challenges/sherlock-and-squares
 */

using System;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            // Cycle through each test case
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                // Parse input
                string input = Console.ReadLine();
                string[] elements = input.Split(' ');
                int min = Convert.ToInt32(elements[0]);
                int max = Convert.ToInt32(elements[1]);

                // Output number of squares
                int result = CountPerfectSquares(min, max);
                Console.WriteLine(result);
            }
        }

        // Returns the number of perfect squares between a and b inclusive
        public static int CountPerfectSquares(int a, int b)
        {
            // Find the number of perfect squares between A & B (INCLUSIVE)
            return (int)Math.Sqrt(b) - (int)Math.Sqrt(a - 1);
        }

    }
}
