using System;

namespace Exercise7_PIGLET
{
    internal class Program
    {
        private static readonly Random _rnd = new();
        private static int _score;

        private static void Main(string[] args)
        {
            Play();
        }

        private static void Play()
        {
            do
            {
                Console.WriteLine("    Roll? Y/N");
                var ch = Console.ReadLine().ToUpper()[0];
                if (ch == 'Y')
                {
                    var roll = _rnd.Next(1, 5);
                    _score += roll;
                    Console.Clear();
                    Console.WriteLine($"    You rolled : {roll}.");
                    Console.WriteLine($"    Current score: {_score}\n");

                    if (roll == 1)
                    {
                        _score = 0;
                        Console.WriteLine($"    GameOver {_score}");
                        Exit();
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            } while (_score != 0);

            Exit();
        }

        private static void Exit()
        {
            Console.Write("    Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            var ch = Console.ReadLine().ToLower()[0];
            if (ch == 'n') Environment.Exit(0);

            Console.Clear();
            Play();
        }
    }
}