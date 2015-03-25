/*
 * https://www.hackerrank.com/challenges/closest-numbers
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // Convert string of ints into array
            Array.Sort(numbers);
            int? difference = null;
            List<int> minNumbers = new List<int>();
            // Cycle through each pair of numbers determining the pair with the smallest difference
            for (int i = 0; i < arraySize; i++)
            {
                int tempDifference = 0;
                if (i + 1 != arraySize)
                {
                    tempDifference = numbers[i + 1] - numbers[i];
                    if (difference == null || difference > tempDifference)
                    {
                        minNumbers.Clear();
                        difference = tempDifference;
                        AddPairToList(numbers, minNumbers, i);
                    }
                    else if (difference == tempDifference)
                    {
                        AddPairToList(numbers, minNumbers, i);
                    }     
                }
            }
            foreach (var number in minNumbers)
            {
                Console.Write("{0} ", number);
            }
        }

        private static void AddPairToList(int[] numbers, List<int> minNumbers, int i)
        {
            minNumbers.Add(numbers[i]);
            minNumbers.Add(numbers[i + 1]);
        }
    }
}
