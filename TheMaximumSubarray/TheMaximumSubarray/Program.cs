/*
 * https://www.hackerrank.com/challenges/maxsubarray
 */

using System;
using System.Linq;

namespace TheMaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cycle through each test case
            int maxNumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < maxNumberOfTestCases; currentTestCase++)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // Convert input into an int array

                long[] results = calculateMaxSubArraySums(numbers);
                Console.WriteLine("{0} {1}", results[0], results[1]);
            }
        }

        // Calculates both the contiguous and non-contiguous sums of the indicated array
        // Based on Kadane's algorithm
        // Returns an array with both of the sums 
        // results[0] = contigious sum
        // result[1] = non-contigious sum
        private static long[] calculateMaxSubArraySums(int[] numbers)
        {
            long maxContiguousSum = long.MinValue;
            long maxNonContiguousSum = 0;
            long currentMaxSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentMaxSum += numbers[i];
                if (currentMaxSum > maxContiguousSum)
                {
                    maxContiguousSum = currentMaxSum;
                }
                if (currentMaxSum < 0)
                {
                    currentMaxSum = 0;
                }
                if (numbers[i] > 0)
                {
                    maxNonContiguousSum += numbers[i];
                }
            }
            if (maxNonContiguousSum == 0) // If max non-contigious sum is still zero 
            {
                maxNonContiguousSum = numbers.Max(); // Then set it to the max value in the array
            }
            long[] results = { maxContiguousSum, maxNonContiguousSum };
            return results;
        }
    }
}
