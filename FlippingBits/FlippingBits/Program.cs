using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint listSize = Convert.ToUInt32(Console.ReadLine()); // Obtain list size
            for (int i = 0; i < listSize; i++)
            {
                uint numberToFlip = Convert.ToUInt32(Console.ReadLine()); // Obtain number
                uint flippedNumber = ~numberToFlip; // Flip bits in number
                string flippedBinary = Convert.ToString(flippedNumber, 2); //Convert flipped number to binary
                Console.WriteLine(Convert.ToUInt32(flippedBinary, 2)); // Convert flipped binary to unsigned int
            }
        }
    }
}
