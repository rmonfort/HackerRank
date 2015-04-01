/*
 * https://www.hackerrank.com/challenges/reverse-game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cycle through each test case
            int maxNumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < maxNumberOfTestCases; currentTestCase++)
            {
                // Parse input seperating number of balls and numbered ball to find
                string input = Console.ReadLine();
                int[] elements = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                int numberOfBalls = Convert.ToInt32(elements[0]);
                int numberedBallToFind = elements[1];

                // Generate a array of numbers based on the number of balls
                var numbers = Enumerable.Range(0, numberOfBalls).ToArray();

                // Set starting indexes in order to cycle through the string
                int rightSide = numberOfBalls - 1;
                int leftSide = 0;

                List<int> reversedNumbers = new List<int>();

                // Start from the outside and moving inward, thus reversing the string according to the challenge
                // For example 012 would now be 201
                while (leftSide <= rightSide)
                {
                    if (leftSide != rightSide) // If the left side index isn't equal to the right side index
                    {
                        reversedNumbers.Add(numbers[rightSide]);
                        reversedNumbers.Add(numbers[leftSide]);
                    }
                    else // Otherwise, rightside and left side are equal 
                    {
                        reversedNumbers.Add(numbers[leftSide]); 
                    }
                    leftSide++;
                    rightSide--;
                }

                // Output the index of the ball with the indicated number
                Console.WriteLine(reversedNumbers.IndexOf(numberedBallToFind));

            }
        }
    }
}
