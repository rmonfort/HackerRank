using System;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts = Int32.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine(numbers.Sum());
        }
    }
}
