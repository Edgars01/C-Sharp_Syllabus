using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = GetMenu();
            do
            {             
                if (choice == 1)
                {
                    CalculateCircleArea();
                }
                else if (choice == 2)
                {
                    CalculateRectangleArea();
                }
                else if (choice == 3)
                {
                    CalculateTriangleArea();
                }
                else
                {
                    Console.WriteLine("Bye");
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            userChoice = Convert.ToInt32(Console.ReadLine());
           
            if (userChoice > 4 || userChoice < 1)
            {
                Console.WriteLine("ERROR! Number outside the range!");
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("What is the circle's radius? ");
            int radius = Convert.ToInt32(Console.ReadLine());
            if (radius < 0)
            {
                Console.WriteLine("Error! Only positive numbers please..");
                Exit();
            }
          
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
            BackToMenu();
        }

        public static void CalculateRectangleArea()
        {
            int length = 0;
            int width = 0;

            Console.WriteLine("Enter length? ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            width = Convert.ToInt32(Console.ReadLine());

            if (length < 0 || width < 0)
            {
                Console.WriteLine("Error! Only positive numbers please..");
                Exit();
            }

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
            BackToMenu();
        }

        public static void CalculateTriangleArea()
        {
            int ground = 0;
            int height = 0;
          
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToInt32(Console.ReadLine());         

            if (ground < 0 || height < 0)
            {
                Console.WriteLine("Error! Only positive numbers please..");
                Exit();
            }
          
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
            BackToMenu();
        }

        public static void Exit()
        {
            ConsoleKeyInfo ch;
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            ch = Console.ReadKey();
            if (ch.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            } 
        }

        private static void BackToMenu()
        {
            Console.WriteLine("Press m to get back to Menu: \n");
            string key = Console.ReadKey().Key.ToString();
            if (key.ToUpper() == "M")
            {
                Console.Clear();
                GetMenu();
            }
        }
    }
}
