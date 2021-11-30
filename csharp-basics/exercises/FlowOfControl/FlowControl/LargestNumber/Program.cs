using System;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
       public static int[] terms = new int[0];
       private static int numbOFtim;

        static void Main(string[] args)
        {
            play();
        }

        public static void play()
        {
            Console.WriteLine("Enter number of numbers you wish to input: ");
            var numberOfTimes = Console.ReadLine();
            if (int.TryParse(numberOfTimes, out numbOFtim))
            {
                for (int runs = 0; runs < numbOFtim; runs++)
                {
                    logic();
                    Console.Clear();
                }
                bigestNumAndStuff();
                exit();
            }
            else
            {
                Console.WriteLine("Error! Numbers only: ");
                Console.ReadLine();
                exit();
            }
        }

        public static void logic()
        {
            Console.Write("Enter number: ");
            var userInput = Console.ReadLine();
            int value;
            if (int.TryParse(userInput, out value))
            {
                terms = terms.Append(value).ToArray();
            }
            else
            {
                Console.WriteLine("Error! Numbers only: ");
            }
        }

        private static void exit()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                Environment.Exit(0);
            }
            Console.Clear();
            play();
        }

        private static void bigestNumAndStuff()
        {
            int maxValue = terms.Max();
            int maxIndex = terms.ToList().IndexOf(maxValue);
            Console.WriteLine($"Bigest value you entered is: {maxValue} with index {maxIndex}");      
        }
    }
}
