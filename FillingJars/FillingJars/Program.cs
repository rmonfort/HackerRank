/*
 * https://www.hackerrank.com/challenges/filling-jars
 */

using System;

namespace FillingJars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtain number of candy jars and number of operations
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            long numberOfCandyJars = Convert.ToInt32(elements[0]);
            long numberOfOperations = Convert.ToInt32(elements[1]);

            // Cycle through each operation adding to the sum the number of candies added in each operation
            long sum = 0;
            for (int currentOperation = 0; currentOperation < numberOfOperations; currentOperation++)
            {
                input = Console.ReadLine();
                string[] operation = input.Split(' ');
                long index1 = Convert.ToInt32(operation[0]);
                long index2 = Convert.ToInt32(operation[1]);
                long numberOfCandiesToAdd = Convert.ToInt32(operation[2]);
                sum += (index2 - index1 + 1) * numberOfCandiesToAdd;
            }

            // Output average
            long average = sum / numberOfCandyJars;
            Console.WriteLine(average);
        }
    }
}
