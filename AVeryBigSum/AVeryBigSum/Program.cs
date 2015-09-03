using System;
using System.Linq;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts = Int32.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine().Split(' ').Select(n => Convert.ToInt64(n)).ToArray();
            Console.WriteLine(numbers.Sum());
        }
    }
}
