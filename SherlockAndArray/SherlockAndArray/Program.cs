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

                // Cycle through each element in numbers array 
                for (int i = 0; i < arraySize; i++)
                {
                    long leftHandSum = 0, rightHandSum = 0;

                    if (i == 0) // If index is zero left hand sum is zero by default
                    {
                        rightHandSum = CalculateRightHandSum(arraySize, numbers, i);
                    }
                    else if (i == (arraySize - 1)) // If index is equal to (arraySize - 1) then right hand sum is zero by default
                    {
                        leftHandSum = CalculateLeftHandSum(numbers, i);
                    }
                    else // Otherwise calculate both the left hand sum and right hand sum
                    {
                        leftHandSum = CalculateLeftHandSum(numbers, i);

                        rightHandSum = CalculateRightHandSum(arraySize, numbers, i);
                    }

                    if (leftHandSum == rightHandSum) 
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    else if (i == (arraySize - 1)) // If this is the last element in the array
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }

        // Returns the sum of the numbers to the left of the index i in the numbers array
        private static long CalculateLeftHandSum(int[] numbers, int i)
        {
            int leftHandArraySize = i;
            int[] leftHandArray = new int[leftHandArraySize];
            Array.Copy(numbers, 0, leftHandArray, 0, leftHandArraySize);
            long leftHandSum = leftHandArray.Sum();
            return leftHandSum;
        }

        // Returns the sum of the numbers to the right of the index i in the numbers array
        private static long CalculateRightHandSum(int arraySize, int[] numbers, int i)
        {
            int rightHandArraySize = arraySize - 1 - i;
            int[] rightHandArray = new int[rightHandArraySize];
            int sourceIndex = i + 1;
            Array.Copy(numbers, sourceIndex, rightHandArray, 0, rightHandArraySize);
            long rightHandSum = rightHandArray.Sum();
            return rightHandSum;
        }
    }
}
