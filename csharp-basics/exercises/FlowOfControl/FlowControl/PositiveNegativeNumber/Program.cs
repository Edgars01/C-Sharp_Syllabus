using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                if (value > 0)
                {
                    Console.WriteLine("Number is positive");
                    Console.ReadLine();
                }
                else if (value < 0)
                {
                    Console.WriteLine("Number is negative");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Number is zero");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Error only numbers!");
                Console.ReadLine();
            }
        }
    }
}
