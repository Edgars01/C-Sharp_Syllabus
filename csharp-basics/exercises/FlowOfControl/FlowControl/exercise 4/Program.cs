using System;

namespace exercise_4
{
    internal class Program
    {
        private static int _value;
        static void Main(string[] args)
        {
            menu();
        }
        private static void exit()
        {
            Console.Write("\nDo you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
            Console.Clear();
            menu();
        }

        private static void menu()
        {
            Console.WriteLine("Hi, please choose: \n");
            Console.WriteLine("   1) a nested -if statement version or ");
            Console.WriteLine("   2) a switch-case -default statement.");
            Console.WriteLine("   3) Exit.\n");
            Console.Write("Enter 1, 2 or 3: ");

            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out _value))
            {
                if (_value > 3 || _value < 1)
                { 
                    Console.WriteLine("Error! Only numbers 1 to 3");
                    exit();
                }

                if (_value == 1)
                {
                    nestedIfChoice();
                }
                else if (_value == 2)
                {
                    switchChoice();
                }
                else
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Error! Only numbers 0 to 6!");
                Console.ReadLine();
            }
        }

        private static void nestedIfChoice()
        {
            Console.Clear();
            Console.WriteLine("Hello! Enter 0, 1, ..., 6 for day of week: ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out _value))
            {
                if (_value > 6 || _value < 0)
                {
                    Console.WriteLine("Not a valid day");
                }
                else if (_value == 0)
                {
                    Console.WriteLine("Monday");
                }
                else if (_value == 1)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (_value == 2)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (_value == 3)
                {
                    Console.WriteLine("Thursday");
                }
                else if (_value == 4)
                {
                    Console.WriteLine("Friday");
                }
                else if (_value == 5)
                {
                    Console.WriteLine("Saturday");
                }
                else
                {
                    Console.WriteLine("Sunday");
                }
            }
            else
            {
                Console.WriteLine("Error! Enter number from 0 to 6: ");
                Console.ReadLine();
            }
            exit();
        }

        private static void switchChoice()
        {
            Console.Clear();
            Console.WriteLine("Enter the number from 0 to 6.");
            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day.");
                    break;
            }
            exit();
        }
    }
}
