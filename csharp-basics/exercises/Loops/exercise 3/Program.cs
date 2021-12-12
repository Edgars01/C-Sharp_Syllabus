using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rnd.Next(1, 21);
            }
            Console.WriteLine("Enter position out of 20 random numbers you want to know");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < 0 || userInput > 21)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{randomArr[userInput]}");
            }
            Console.ReadKey();
        }
    }
}
