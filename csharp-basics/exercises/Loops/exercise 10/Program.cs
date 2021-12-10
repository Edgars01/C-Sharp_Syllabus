using System;

namespace Exercise10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            var min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            var max = Convert.ToInt32(Console.ReadLine());

            for (var i = min; i < max; i++)
            {
                for (var j = i; j < max; j++)
                {
                    Console.Write(j);
                }

                for (var j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}