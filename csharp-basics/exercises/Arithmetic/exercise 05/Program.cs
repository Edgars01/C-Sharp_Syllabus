using System;

namespace exercise_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randonInt = r.Next(0, 100);
            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
            int random = Int32.Parse(Console.ReadLine());

            if (random > randonInt)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {randonInt}.");
            }
            else if (random < randonInt)
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {randonInt}.");
            }
            else
            {
                Console.WriteLine($"You guessed it!  What are the odds?!?");
            }
        }
    }
}
