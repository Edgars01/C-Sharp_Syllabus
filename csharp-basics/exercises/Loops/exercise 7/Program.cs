using System;

namespace Exercise7_PIGLET
{
    internal class Program
    {
        private static Random _rnd = new Random();
        private static int _score = 0;

        static void Main(string[] args)
        {
            Play();
        }

        private static void Play()
        {
            do
            {
                Console.WriteLine("    Roll? Y/N");
                char ch = Console.ReadLine()[0];
                if (ch == 'y' || ch == 'Y')
                {
                    int roll = _rnd.Next(1, 5);
                    _score += roll;
                    Console.Clear();
                    Console.WriteLine($"    You rolled : {roll}.");
                    Console.WriteLine($"    Current score: {_score}\n");

                    if (roll == 1)
                    {
                        _score = 0;
                        Console.WriteLine($"    GameOver {_score}");
                        exit();
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            } while (_score != 0);
            exit();
        }

        private static void exit()
        {
            Console.Write("    Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (char.IsLower(ch) || char.IsUpper(ch))
            {
                Environment.Exit(0);
            }
            Console.Clear();
            Play();
        }
    }
}