using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadKey();
        }
    }
}