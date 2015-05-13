/*
 * https://www.hackerrank.com/challenges/cavity-map
 */

using System;

namespace CavityMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMap = Convert.ToInt32(Console.ReadLine());
            int[,] map = new int[sizeOfMap, sizeOfMap];
            PopulateMap(sizeOfMap, map);
            PrintCavityMap(sizeOfMap, map);
        }

        private static void PrintCavityMap(int sizeOfMap, int[,] map)
        {
            for (int row = 0; row < sizeOfMap; row++)
            {
                for (int column = 0; column < sizeOfMap; column++)
                {
                    int value = map[row, column];
                    if (IsBorder(sizeOfMap, row, column))
                    {
                        Console.Write(value);
                        continue;
                    }

                    int top = map[row - 1, column];
                    int bottom = map[row + 1, column];
                    int left = map[row, column - 1];
                    int right = map[row, column + 1];
                    if (IsCavity(top, bottom, left, right, value))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(value);
                    }
                }
                Console.WriteLine();
            }
        }

        private static bool IsBorder(int sizeOfMap, int row, int column)
        {
            return row == 0 || column == 0 || row == sizeOfMap - 1 || column == sizeOfMap - 1;
        }

        private static bool IsCavity(int top, int bottom, int left, int right, int value)
        {
            return value > top && value > bottom && value > left && value > right;
        }

        private static void PopulateMap(int sizeOfMap, int[,] map)
        {
            for (int row = 0; row < sizeOfMap; row++)
            {
                string input = Console.ReadLine();
                for (int column = 0; column < sizeOfMap; column++)
                {
                    map[row, column] = (int)Char.GetNumericValue(input[column]);
                }
            }
        }
    }
}
