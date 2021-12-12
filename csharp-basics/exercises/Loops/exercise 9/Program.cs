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
                var desiredSum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Desired Sum ({desiredSum}) ");
                var rnd = new Random();
                var dice = rnd.Next(1, 7);
                var diceTwo = rnd.Next(1, 7);
                Console.WriteLine($"{dice} and {diceTwo}");
                if (dice + diceTwo == desiredSum) Console.WriteLine("You Won!");
                Console.WriteLine("Again? y/n");
                var answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "N" || answer != "n");

            Environment.Exit(0);
        }
    }
}