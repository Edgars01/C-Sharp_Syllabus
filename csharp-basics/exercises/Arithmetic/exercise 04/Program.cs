using System;

namespace exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product1ToN(10);
        }

        static void Product1ToN(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The product of integers from 1 to {num} is {factorial}.");
        }
    }
}
