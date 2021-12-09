using System;
using System.Linq;

namespace Exercise8_hanging
{
    internal class Program
    {
        private static Random random = new Random();
        private static string[] myArray = {"muonneutrino", "sirisaacnewton", "higgsboson", "boroncarbide", "srinivasaramanujan", "straindisplacementequation"};
        private static int arrayRandom = random.Next(0, 6);
        private static string[] unknownChars = new string[myArray[arrayRandom].Length];
        private static string misses = "";
        private static int counter = 0;
        private static int hitPoints = 10;
       
        static void Main(string[] args)
        {
            Play();    
        }

        private static void Play()
        {
            MakeHiddenChars();
            do
            {
                Display();
                Winner();
                Looser();
                Logic();

            } while (Winner() == false);
        }

        private static void MakeHiddenChars()
        {
            for (var i = 0; i < myArray[arrayRandom].Length; i++)
            {
                unknownChars[i] = "_ ";
            }
        }

        private static bool Winner()
        {
            bool win = false;
            if (counter == myArray[arrayRandom].Length)
            {
                win = true;
                Console.WriteLine("You WIN");
                Exit();
            }
            return win;
        }

        private static void Looser()
        {
            if (hitPoints == 0)
            {
                Console.WriteLine("You LOOSE");
                Exit();
            }
        }

        private static void Exit()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine().ToLower()[0];
            if (ch == 'n')
            {
                Environment.Exit(0);
            }
            Play();
        }

        private static void Display()
        {
            Console.Clear();
            Console.WriteLine($"{hitPoints} HP left");
            Console.Write("Word: ");
            for (var index = 0; index < unknownChars.Length; index++)
            {
                Console.Write(unknownChars[index]);
            }
            Console.WriteLine();
            Console.Write("Misses: " + misses);
            Console.Write("Guess: ");
        }

        private static void Logic()
        {       
            string guess = Console.ReadLine();
            bool isGuessLetter = guess.All(Char.IsLetter);

            if (misses.Contains(guess) || unknownChars.Contains(guess))
            {
                Console.WriteLine("Error! You already wrote this letter");
                Console.Write("Guess a letter: ");
                guess = Console.ReadLine();
                isGuessLetter = guess.All(Char.IsLetter);
            }        

            while (isGuessLetter == false || guess.Length != 1)
            {
                Console.WriteLine("Please enter only a single letter!");
                Console.Write("Guess a letter: ");
                guess = Console.ReadLine();
                isGuessLetter = guess.All(Char.IsLetter);
            }

            bool missed = true;

            for (int j = 0; j < myArray[arrayRandom].Length; j++)
            {
                if (char.Parse(guess) == myArray[arrayRandom][j])
                {
                    counter++;
                    unknownChars[j] = Convert.ToString(guess);
                    missed = false;
                }
            }

            if (missed)
            {
                misses += guess;
                hitPoints--;
            }
        }
    }
}
