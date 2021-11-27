using System;

namespace exercise_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter single digit numbers(Maximum 10 numbers):  ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                int modulus  = number % 10;
                number /= 10;
                sum += modulus;
            }
            Console.WriteLine($"Sum of all the numbers: {sum}");
        }
    }
}
