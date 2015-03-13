/*
 * https://www.hackerrank.com/challenges/solve-me-first
 */

using System;

namespace SolveMeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int sum = CalculateSum(value1, value2);
            Console.WriteLine(sum);
        }

        private static int CalculateSum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
