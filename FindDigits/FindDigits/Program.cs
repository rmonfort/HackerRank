/*
 * https://www.hackerrank.com/challenges/find-digits
 */

using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine()); // Obtain number of test cases

            // Cycle through each test case
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                string stringNumber = Console.ReadLine(); // Obtain number in string form
                long number = Convert.ToInt64(stringNumber); // Convert string to int64
                int[] digits = new int[stringNumber.Length]; // Create an array based on the length of the string

                // Cycle through each character in the string number, convert the character to a int, and save into digits array
                for (int i = 0; i < stringNumber.Length; i++)
                {
                    digits[i] = (int)Char.GetNumericValue(stringNumber[i]);
                }
                int numberOfPerfectDivisors = 0; // Set default value for the number of perfect divisors

                // Cycle through each digit
                foreach (var digit in digits)
                {
                    if (digit == 0) // If digit is equal to zero, can't use as divisor
                    {
                        continue; // Skip digit
                    }
                    else if (number % digit == 0) // If the number when divided by the digit leaves no remainder
                    {
                        numberOfPerfectDivisors++; // Increment the number of perfect divisors
                    }
                }
                Console.WriteLine(numberOfPerfectDivisors);
            }
        }
    }
}
