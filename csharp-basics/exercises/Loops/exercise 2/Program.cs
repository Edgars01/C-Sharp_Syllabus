using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadKey();
        }
    }
}