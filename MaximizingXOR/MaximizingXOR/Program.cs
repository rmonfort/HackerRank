/*
 * https://www.hackerrank.com/challenges/maximizing-xor
 */

using System;

namespace MaximizingXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Brute force was used because the constraints were reasonable enough. (1 <= leftValue <= rightValue <= 10^3)
             * However, if the upper end of the constraint was much higher, this solution would be terribly inefficient
             */

            int leftValue = Convert.ToInt32(Console.ReadLine()); // Obtain left value
            int rightValue = Convert.ToInt32(Console.ReadLine()); // Obtain right value
            int maximumXORValue = 0;

            /* Cycle through all XOR combinations and obtain the maximum XOR value 
             * For example L = 10, R = 12
             * 10⊕10=0 
             * 10⊕11=1 
             * 10⊕12=6        
             * 11⊕11=0  
             * 11⊕12=7 
             * 12⊕12=0 
             */

            while (leftValue <= rightValue)
            {
                for (int currentRightValue = leftValue; currentRightValue <= rightValue; currentRightValue++)
                {
                    int XORValue = leftValue ^ currentRightValue;
                    if (XORValue > maximumXORValue)
                    {
                        maximumXORValue = XORValue;
                    }
                }
                leftValue++;
            }

            Console.WriteLine(maximumXORValue);
            
        }

    }
}
