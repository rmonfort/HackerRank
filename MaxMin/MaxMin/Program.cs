using System;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIntegers = Convert.ToInt32(Console.ReadLine());
            int numberOfIntegersToSelect = Convert.ToInt32(Console.ReadLine()); 
            int[] arrayOfIntegers = new int[numberOfIntegers];

            // Populate array of integers and sort it
            for (int i = 0; i < numberOfIntegers; i++)
            {
                arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arrayOfIntegers);

            // Calculate the unfairness of each k-pair of numbers in array while retaining the smallest unfairness
            int currentIndex = 0;
            int adjacentIndex = numberOfIntegersToSelect - 1;
            int? minUnfairness = null;
            while (adjacentIndex != arrayOfIntegers.Length)
            {
                int tempUnfairness = arrayOfIntegers[adjacentIndex] - arrayOfIntegers[currentIndex];
                if (minUnfairness == null || minUnfairness > tempUnfairness)
                {
                    minUnfairness = tempUnfairness;
                }
                currentIndex++;
                adjacentIndex++;
            }
            Console.WriteLine(minUnfairness);
        }
    }
}
