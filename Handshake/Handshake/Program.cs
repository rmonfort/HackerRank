/*
 * https://www.hackerrank.com/challenges/handshake
 */

using System;

namespace Handshake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cycle through each test case
            int maxNumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < maxNumberOfTestCases; currentTestCase++)
            {
                int numberOfBoardDirectors = Convert.ToInt32(Console.ReadLine());


                // Original solution
                //
                // Calculate the number of hand shake combinations by calculating the difference between the number of board members and i,
                // and adding it to the total number of hand shakes
                //
                //long totalNumberOfHandshakes = 0;
                //for (int i = 1; i <= numberOfBoardDirectors; i++)
                //{
                //    long possibleHandShakeCombos = numberOfBoardDirectors - i; 
                //    totalNumberOfHandshakes += possibleHandShakeCombos;
                //}

                int totalNumberOfHandshakes = numberOfBoardDirectors * (numberOfBoardDirectors - 1) / 2;
                Console.WriteLine(totalNumberOfHandshakes);
            }
        }
    }
}
