﻿using System;

namespace Binary_Digits_Count_AS
{
    class BinaryDigitsCountAS
    {
        static void Main(string[] args)
        {
            // Read input
            byte B = byte.Parse(Console.ReadLine());
            short N = short.Parse(Console.ReadLine());

            // Solve
            for (int i = 1; i <= N; i++)
            {
                int count = 0;
                uint number = uint.Parse(Console.ReadLine());
                while (number != 0)
                {
                    if ((number & 1) == B)
                    {
                        count++;
                    }
                    number = number >> 1;
                }

                // Write answers
                Console.WriteLine(count);
            }
        }
    }
}