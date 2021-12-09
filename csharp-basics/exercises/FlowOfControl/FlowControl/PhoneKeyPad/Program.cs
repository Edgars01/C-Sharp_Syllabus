using System;
using System.Linq;

namespace PhoneKeyPad
{
    internal class Program
    {
        private static int _value;

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Exit()
        {
            Console.Write("\n\nDo you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine().ToLower()[0];
            if (ch == 'n')
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }
            Console.Clear();
            Menu();
        }

        private static void Menu()
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
                    Exit();
                }

                if (_value == 1)
                {
                    NestedIfChoice();
                }
                else if (_value == 2)
                {
                    SwitchChoice();
                }
                else
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Error! Letters only: ");
                Console.ReadLine();
            }
        }

        private static void NestedIfChoice()
        {
            Console.Clear();
            Console.WriteLine("Enter text: \n");
            var userInput = Console.ReadLine();
            string lowered = userInput.ToLower();
            if (lowered.All(c => Char.IsLetterOrDigit(c)))
            {    
                foreach (char letter in lowered)
                {
                    if (letter == 'a' || letter == 'b' || letter == 'c')
                    {
                        Console.Write(2);
                    }
                    else if (letter == 'd' || letter == 'e' || letter == 'f')
                    {
                        Console.Write(3);
                    }
                    else if (letter == 'g' || letter == 'h' || letter == 'i')
                    {
                        Console.Write(4);
                    }
                    else if (letter == 'j' || letter == 'k' || letter == 'l')
                    {
                        Console.Write(5);
                    }
                    else if (letter == 'm' || letter == 'n' || letter == 'o')
                    {
                        Console.Write(6);
                    }
                    else if (letter == 'p' || letter == 'q' || letter == 'r' || letter == 's')
                    {
                        Console.Write(7);
                    }
                    else if (letter == 't' || letter == 'u' || letter == 'v')
                    {
                        Console.Write(8);
                    }
                    else if (letter == 'w' || letter == 'x' || letter == 'y' || letter == 'z')
                    {
                        Console.Write(9);
                    }
                    else
                    {
                        Console.Write("Error! Not a char / not English alphabet char!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error! Letters only: ");
                Console.ReadLine();
            }
            Exit();
        }

        private static void SwitchChoice()
        {
            Console.Clear();
            Console.WriteLine("Enter text: \n");
            var input = Console.ReadLine();

            string lowered = input.ToLower();
            if (lowered.All(c => Char.IsLetterOrDigit(c)))
            {
                foreach (var inChar in lowered)
                {
                    switch (inChar)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            Console.Write(2);
                            break;
                        case 'd':
                        case 'e':
                        case 'f':
                            Console.Write(3);
                            break;
                        case 'g':
                        case 'h':
                        case 'i':
                            Console.Write(4);
                            break;
                        case 'j':
                        case 'k':
                        case 'l':
                            Console.Write(5);
                            break;
                        case 'm':
                        case 'n':
                        case 'o':
                            Console.Write(6);
                            break;
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            Console.Write(7);
                            break;
                        case 't':
                        case 'u':
                        case 'v':
                            Console.Write(8);
                            break;
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            Console.Write(9);
                            break;
                        case ' ':
                            Console.Write(0);
                            break;
                        default:
                            Console.WriteLine("Error! Not a char / not English alphabet char!");
                            break;
                    }           
                }
            }
            Exit();
        }
    }
}
