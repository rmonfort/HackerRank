/*
 * https://www.hackerrank.com/challenges/diagonal-difference
*/

using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = Int32.Parse(Console.ReadLine());
            int[] leftDiagonal = new int[dimension];
            int[] rightDiagonal = new int[dimension];
            for (int left = 0, right = dimension - 1; left < dimension; left++, right--)
            {
                int[] input = Console.ReadLine().Split(' ').Select(n => Int32.Parse(n)).ToArray();
                leftDiagonal[left] = input[left];
                rightDiagonal[right] = input[right];
            }
            int absoluteDifference = Math.Abs(leftDiagonal.Sum() - rightDiagonal.Sum());
            Console.WriteLine(absoluteDifference);
        }
    }
}
