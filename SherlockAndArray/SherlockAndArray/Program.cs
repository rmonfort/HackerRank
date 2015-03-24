/* 
 * https://www.hackerrank.com/challenges/sherlock-and-array
 */

using System;
using System.Linq;

namespace SherlockAndArray
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
                int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // Convert space seperated string to int array
                long leftHandSum = 0, rightHandSum = numbers.Sum();

                // Cycle through numbers array calculating the left hand sum and right hand sum accordingly 
                for (int i = 0; i < arraySize; i++)
                {
                    if (i != 0) 
                    {
                        leftHandSum += numbers[i - 1];
                    }
                    rightHandSum -= numbers[i];
                    if (leftHandSum == rightHandSum)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    else if (i == (arraySize - 1))
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
