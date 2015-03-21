/*
 * https://www.hackerrank.com/challenges/tutorial-intro
 */

using System;
using System.Linq;

namespace IntroToTutorialChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueToFind = Convert.ToInt32(Console.ReadLine());
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string stringOfNumbers = Console.ReadLine();
            int[] arrayOfNumbers = stringOfNumbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // LINQ convert string to int array
            Array.Sort(arrayOfNumbers);
            int indexOfValue = Array.BinarySearch(arrayOfNumbers, valueToFind); // Do a binary search for the value to find
            Console.WriteLine(indexOfValue);
        }
    }
}
