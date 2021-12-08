using System;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
       private static int[] _terms = new int[0];
       private static int numbOFtim;

        static void Main(string[] args)
        {
            Play();
        }
        public static void Play()
        {
            Console.WriteLine("Enter number of numbers you wish to input: ");
            Array.Clear(_terms, 0, _terms.Length);
            var numberOfTimes = Console.ReadLine();
            if (int.TryParse(numberOfTimes, out numbOFtim))
            {
                for (int runs = 0; runs < numbOFtim; runs++)
                {
                    Logic();
                    Console.Clear();
                }
                BigestNumAndStuff();
                Exit();
            }
            else
            {
                Console.WriteLine("Error! Numbers only: ");
                Console.ReadLine();
                Exit();
            }
        }

        public static void Logic()
        {
            Console.Write("Enter number: ");
            var userInput = Console.ReadLine();
            int value;
            if (int.TryParse(userInput, out value))
            {
                _terms = _terms.Append(value).ToArray();
            }
            else
            {
                Console.WriteLine("Error! Numbers only: ");
            }
        }

        private static void Exit()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                Environment.Exit(0);
            }
            Console.Clear();
            Play();
        }

        private static void BigestNumAndStuff()
        {
            int maxValue = _terms.Max();
            int maxIndex = _terms.ToList().IndexOf(maxValue);
            Console.WriteLine($"Bigest value you entered is: {maxValue}");      
        }
    }
}
