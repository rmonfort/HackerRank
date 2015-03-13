/*
 * https://www.hackerrank.com/challenges/the-love-letter-mystery
 */

using System;
using System.Linq;

namespace TheLoveLetterMystery
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfTestCases = Convert.ToUInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                uint minNumberOfOperations = 0;
                string currentString = Console.ReadLine();
                if (!IsPalindrome(currentString))
                {
                    minNumberOfOperations = ReduceToPalindrome(minNumberOfOperations, currentString);
                }
                Console.WriteLine(minNumberOfOperations);
            }
        }

        // Converts a string to a palindrone by reducing the values of conflicting letters, i.e. 'd' can be changed to 'c', but 'c' cannot be changed to 'd'
        // Returns the minimum number of operations performed to convert the indicated string to a palindrome
        private static uint ReduceToPalindrome(uint minNumberOfOperations, string stringToConvert)
        {
            // Set minimum and maximum indexes 
            int min = 0;
            int max = stringToConvert.Length - 1;

            // Cycles through the string starting from the outside and moving inward comparing each value and adjusting them as neccessary 
            while (true)
            {
                if (min > max)
                {
                    break;
                }
                char left = stringToConvert[min];
                char right = stringToConvert[max];
                while (char.ToLower(left) != char.ToLower(right))
                {
                    if (char.ToLower(left) > char.ToLower(right))
                    {
                        left--;

                    }
                    else
                    {
                        right--;
                    }
                    minNumberOfOperations++;
                }
                min++;
                max--;
            }
            return minNumberOfOperations;
        }

        // Returns true if indicated string is a palindrome
        private static bool IsPalindrome(string stringToTest)
        {
            // Reverse string to be tested
            char[] temp = stringToTest.ToArray();
            Array.Reverse(temp);
            string reversedString = new string(temp);

            // Compare the string to be tested to it's reversed copy and return the boolean result
            bool result = stringToTest.Equals(reversedString, StringComparison.OrdinalIgnoreCase); // ignore case
            return result;
        }
    }
}
