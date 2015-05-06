/*
 * https://www.hackerrank.com/challenges/service-lane
 */

using System;
using System.Linq;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = ConvertStringToIntArray(Console.ReadLine());
            int lengthOfFreeweay = elements[0];
            int numberOfTestCases = elements[1];
            int[] freeway = ConvertStringToIntArray(Console.ReadLine());

            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                elements = ConvertStringToIntArray(Console.ReadLine());
                int segmentEntry = elements[0];
                int segmentExit = elements[1] + 1;
                int arraySize = segmentExit - segmentEntry;
                int[] segment = new int[arraySize];
                Array.Copy(freeway, segmentEntry, segment, 0, arraySize);
                int largestVehicle = segment.Min();
                Console.WriteLine(largestVehicle);
            }
        }

        public static int[] ConvertStringToIntArray(string stringToConvert)
        {
            int[] elements = stringToConvert.Split(' ').Select(str => int.Parse(str)).ToArray();
            return elements;
        }

    }
}
