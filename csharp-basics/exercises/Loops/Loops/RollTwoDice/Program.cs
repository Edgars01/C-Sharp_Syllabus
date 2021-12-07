using System;

namespace RollTwoDice
{
    internal class Program
    {
        static string answer;
        static void Main(string[] args)
        {
            do 
            {
                Console.WriteLine("LETS ROLL DICE!");
                Console.WriteLine("Desired Sum : ");
                int desiredSum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Desired Sum ({desiredSum}) ");
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);
                Console.WriteLine($"{dice} and {diceTwo}");
                if (dice + diceTwo == desiredSum)
                { 
                    Console.WriteLine("You Won!");
                }
                Console.WriteLine("Again? y/n");
                string answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "N" || answer != "n");
            Environment.Exit(0);
        }
    }
}
