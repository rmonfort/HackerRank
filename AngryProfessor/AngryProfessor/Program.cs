using System;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < maxNumberOfTestCases; currentTestCase++)
            {
                // Parse first line of test case retrieving class size and the minimum number of students needed in order for class not to be cancelled
                string input = Console.ReadLine();
                string[] elements = input.Split(' ');
                int classSize = Convert.ToInt32(elements[0]);
                int minNumberOfStudentsNeeded = Convert.ToInt32(elements[1]);

                // Parse second line of test case retrieving each students arrival time
                input = Console.ReadLine();
                int[] studentArrivalTimes = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray(); // LINQ makes this a little harder to read but I need practice

                // Cycle through the sorted array of arrival times
                Array.Sort(studentArrivalTimes);
                foreach (var arrivalTime in studentArrivalTimes)
                {
                    if (arrivalTime < 0) // If a student is late
                    {
                        classSize--; // decrement the class size
                        if (classSize < minNumberOfStudentsNeeded) // If the class size is now less than the minimum number of students needed
                        {
                            Console.WriteLine("YES"); // Class is cancelled
                            break; // Stop processing the array
                        }
                    }
                    else // The rest of the students are on time
                    {
                        Console.WriteLine("NO"); // Class is in session 
                        break; // Stop processing the array
                    }
                }
            }
        }
    }
}
