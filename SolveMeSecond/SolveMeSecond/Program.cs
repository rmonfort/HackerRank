using System;

namespace SolveMeSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                string elements = Console.ReadLine();
                string[] splitElements = elements.Split(' ');
                int value1 = Convert.ToInt32(splitElements[0]);
                int value2 = Convert.ToInt32(splitElements[1]);
                int sum = CalculateSum(value1, value2);
                Console.WriteLine(sum);
            }
        }

        private static int CalculateSum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
