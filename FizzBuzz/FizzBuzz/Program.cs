/*
 * https://www.hackerrank.com/challenges/fizzbuzz
 */

using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).Select(
                n =>
                (n % 15 == 0) ? "FizzBuzz" :
                (n % 3 == 0) ? "Fizz" :
                (n % 5 == 0) ? "Buzz" :
                n.ToString()).ToList().ForEach(Console.WriteLine);
        }
    }
}
