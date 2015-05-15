/*
 * https://www.hackerrank.com/challenges/manasa-and-stones
 */

using System;

namespace ManasaAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                int numberOfStones = Convert.ToInt32(Console.ReadLine());
                int difference1 = Convert.ToInt32(Console.ReadLine());
                int difference2 = Convert.ToInt32(Console.ReadLine());
                int smallestDifference = Math.Min(difference1, difference2);
                int largestDifference = Math.Max(difference1, difference2);
                int difference = largestDifference - smallestDifference;
                int currentPossibleValue = smallestDifference * (numberOfStones - 1);
                int maxPossibleValue = largestDifference * (numberOfStones - 1);

                if (difference == 0)
                {
                    Console.WriteLine(currentPossibleValue);
                    continue;
                }
                while (currentPossibleValue <= maxPossibleValue)
                {
                    Console.Write(currentPossibleValue + " ");
                    currentPossibleValue += difference;
                }
                Console.WriteLine();
            }
        }
    }
}
