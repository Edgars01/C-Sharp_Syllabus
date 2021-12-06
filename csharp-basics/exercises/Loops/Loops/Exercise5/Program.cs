using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter first word: ");
            string secondWord = Console.ReadLine();
            Console.Write(firstWord);
            for (int i = 1; i < 31 - firstWord.Length - secondWord.Length; i++)
            {
                Console.Write(".");
            }
            Console.Write(secondWord);
            Console.ReadKey();
        }
    }
}
