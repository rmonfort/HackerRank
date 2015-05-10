/*
 * https://www.hackerrank.com/challenges/cut-the-sticks
 */

using System;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSticks = Convert.ToInt32(Console.ReadLine());
            int[] sticks = new int[numberOfSticks];
            sticks = Console.ReadLine().Split(' ').Select(stick => Convert.ToInt32(stick)).ToArray();

            while (IsPositive(sticks[0]))
            {
                Array.Sort(sticks);
                int cutOperations = 0;
                int lengthOfSmallestStick = 0;
                foreach (var stick in sticks)
                {
                    if (IsPositive(stick))
                    {
                        lengthOfSmallestStick = stick;
                        break;
                    }
                }

                Array.Reverse(sticks);
                for (int i = 0; i < numberOfSticks; i++)
                {
                    if (IsPositive(sticks[i]))
                    {
                        sticks[i] -= lengthOfSmallestStick;
                        cutOperations++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(cutOperations);
            }
        }

        private static bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
