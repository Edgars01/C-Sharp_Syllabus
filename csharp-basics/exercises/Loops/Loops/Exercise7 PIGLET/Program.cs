using System;

namespace Exercise7_PIGLET
{
    internal class Program
    {
        private static Random rnd = new Random();
        private static int score = 0;

        static void Main(string[] args)
        {

            play();
        }

        private static void play()
        {
            do
            {
                Console.WriteLine("    Roll? Y/N");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    int roll = rnd.Next(1, 5);
                    score += roll;
                    Console.Clear();
                    Console.WriteLine($"    You rolled : {roll}.");
                    Console.WriteLine($"    Current score: {score}\n");

                    if (roll == 1)
                    {
                        score = 0;
                        Console.WriteLine($"    GameOver {score}");
                        exit();
                    }
                }
                else 
                {
                    Environment.Exit(0);
                }
            } while (score != 0);
            exit();
        }

        private static void exit()
        {
            Console.Write("    Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                Environment.Exit(0);
            }
            Console.Clear();
            play();
        }
    }
}
