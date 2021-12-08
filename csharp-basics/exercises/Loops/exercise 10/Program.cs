using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }

                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}