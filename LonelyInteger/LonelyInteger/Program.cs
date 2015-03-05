using System;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIntegers = Convert.ToInt32(Console.ReadLine()); // Read in number of integers
            string elements = Console.ReadLine(); // Read in integers

            // Seperate them by ' ' and sort them
            string[] Integers = new string[numberOfIntegers]; 
            Integers = elements.Split(' ');
            Array.Sort(Integers);

            // Cycle through the array looking the lonely integer, if found immediately stop processing the array
            string lonelyInteger = "";
            foreach (var integer in Integers)
            {
                if (lonelyInteger == "") // If lonelyInteger is empty, fill it with a value
                {
                    lonelyInteger = integer;
                }
                else if (lonelyInteger == integer) // if lonelyInteger isn't lonely, empty it out
                {
                    lonelyInteger = "";
                }
                else if (lonelyInteger != integer) // if lonely integer is truly lonely, stop processing the array
                {
                    break;
                }
            }
            Console.WriteLine(lonelyInteger);
        }
    }
}
