/* 
 * https://www.hackerrank.com/challenges/chocolate-feast
 */

using System;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtain number of test cases and cycle through each one
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int currentTestCase = 0; currentTestCase < numberOfTestCases; currentTestCase++)
            {
                // Split input of test case into pocket money, cost for each chocolate, and the number of wrappers needed to get a free chocolate
                string input = Console.ReadLine();
                string[] elements = input.Split(' ');
                int pocketMoney = Convert.ToInt32(elements[0]);
                int costPerChocolate = Convert.ToInt32(elements[1]);
                int wrappersForFreeChocolate = Convert.ToInt32(elements[2]);

                // Calculate number of chocolates that are purchaseable along with number of wrappers you'd get from them
                int totalNumberOfChocolates = pocketMoney / costPerChocolate; 
                int numberOfWrappers = totalNumberOfChocolates; 

                // Apply the chocolate discount based on the current number of wrappers and the number of wrappers it takes to get a free chocolate
                while (numberOfWrappers >= wrappersForFreeChocolate)
                {
                    numberOfWrappers -= wrappersForFreeChocolate; // Redeem wrappers for said chocolate
                    totalNumberOfChocolates++; // Number of chocolate increases
                    numberOfWrappers++; // Thus number of wrappers increases     
                }

                //Output
                Console.WriteLine(totalNumberOfChocolates);
            }
        }
    }
}
