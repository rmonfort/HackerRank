/*
 * https://www.hackerrank.com/challenges/utopian-tree
 */

using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfTestCases = Convert.ToUInt32(Console.ReadLine()); // Obtain number of test cases
            
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++) // Cycle through each test case
            {
                uint heightOfUtopianTree = 1; // Set initial height of Utopian tree
                uint numberOfGrowthCycles = Convert.ToUInt32(Console.ReadLine()); // Obtain number of growth cycles

                for (int currentGrowthCycle = 1; currentGrowthCycle <= numberOfGrowthCycles; currentGrowthCycle++) // Cycle through each growth cycle
                {
                    if (IsOdd(currentGrowthCycle)) // If odd/spring double the height of the tree
                    {
                        heightOfUtopianTree *= 2;
                    }
                    else // else it's even/summer then increase height of tree by one
                    {
                        heightOfUtopianTree += 1;
                    }
                }
                Console.WriteLine(heightOfUtopianTree);
            }
        }

        private static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
