/*
 * https://www.hackerrank.com/challenges/halloween-party
 */

using System;

namespace HalloweenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                int numberOfCuts = Convert.ToInt32(Console.ReadLine());
                long multiplicand = numberOfCuts / 2;
                long multiplier = numberOfCuts - multiplicand;
                long piecesOfChocolate = multiplicand * multiplier;
                Console.WriteLine(piecesOfChocolate);
            }
        }
    }
}
