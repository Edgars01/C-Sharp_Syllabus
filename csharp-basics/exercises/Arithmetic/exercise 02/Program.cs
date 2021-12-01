using System;

namespace exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("Bye!");
        }
    }
}
