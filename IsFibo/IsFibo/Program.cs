/*
 * https://www.hackerrank.com/challenges/is-fibo
 */

using System;

namespace IsFibo
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberOfTestCases = Convert.ToUInt32(Console.ReadLine());

            // Cycle through each test case
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                ulong numberToTest = Convert.ToUInt64(Console.ReadLine());
                if (IsFibonacciNumber(numberToTest))
                {
                    Console.WriteLine("IsFibo");
                }
                else
                {
                    Console.WriteLine("IsNotFibo");
                }
            }
        }

        // Returns true if number is a Fibonacci
        public static bool IsFibonacciNumber(ulong numberToTest)
        {
            if (numberToTest == 0)
            {
                return true;
            }

            ulong prev = 0;
            ulong next = 1;

            // Iteratively generates fibonacci numbers checking it against the number to test
            for (ulong i = 1; i < ulong.MaxValue; i++)
            {
                ulong sum = prev + next;
                prev = next;
                next = sum;
                if (numberToTest == next)
                {
                    return true;
                }
                else if (numberToTest < next)
                {
                    break;
                }
            }
            return false;
        }
    }
}
