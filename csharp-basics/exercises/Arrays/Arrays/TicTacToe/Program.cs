using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char playerXO = 'O';
        private static int playerX = 0;
        private static int playerO = 0;
        private static int PlayerTie = 0;

        private static void Main(string[] args)
        {
            play();
        }

        private static void play()
        {
            do
            {
                InitBoard();
                DisplayBoard();
                MakeMove();
            } while (Win() == false && Tie() == false);

            Console.WriteLine(Tie() ? "It's a tie!" : $"{playerXO} has won!");       
        }

        private static void exit()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine()[0];
            if (ch == 'n' || ch == 'N')
            {
                confirmExit();
            }
            Console.Clear();
            InitBoard();
            play();
        }

        private static void confirmExit()
        {
            Console.Write("Do you really want to quit the Game? (Y/N)? ");
            char ch = Console.ReadLine()[0];

            if (ch == 'y' ||
                ch == 'Y')
            {
                Environment.Exit(0);
            }
            else if (ch == 'n' ||
                 ch == 'N')
            {
                Console.WriteLine("Continue Game...");
                play();
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            winners();
            Console.WriteLine("");
            Console.WriteLine("           0  1  2");
            Console.WriteLine("         0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("           --+-+--");
            Console.WriteLine("         1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("           --+-+--");
            Console.WriteLine("         2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("           --+-+--");
            Console.WriteLine("");
        }

        private static void MakeMove()
        {
            int y;
            int x;
            Console.WriteLine("Enter position on x axys 0, 1, 2");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("That's not a number. Please Enter a number.");
            }
            Console.WriteLine("Enter position on y axys 0, 1, 2");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("That's not a number. Please Enter a number.");
            }

            if (0 < x && x > 3)
            {
                Console.WriteLine("Number not in range");
            }
            else if (0 < y && y > 3)
            {
                Console.WriteLine("Number not in range");
            }

            if (board[y, x] != ' ')
            {
                playerXO = playerXO == 'X' ? 'X' : 'O';
            }
            else
            {
                playerXO = playerXO == 'X' ? 'O' : 'X';
            }

            if (board[y, x] != ' ')
            {
                Console.WriteLine("Invalid move, try again.\n");
                MakeMove();
            }

            board[y, x] = playerXO;
            Console.Clear();
            DisplayBoard();
            Win();
        }

        private static bool Tie()
        {
            bool tie = true;
            int freeSpots = 9;
            for (int outer = 0; outer < 3; outer++)
            {
                for (int inner = 0; inner < 3; inner++)
                {
                    if (board[outer, inner] != ' ')
                    {
                        freeSpots--;
                        if (freeSpots == 0)
                        {
                            Console.WriteLine("It's a Tie!");
                            tie = false;
                            Console.ReadKey();
                            PlayerTie++;
                        }
                    }
                    else
                    {
                        MakeMove();
                    }
                }
            }
            return tie;
        }

        static bool Win()
        {
            bool win = false;
            if ((board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
                || (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
                || (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
                || (board[2, 2] == 'X' && board[1, 1] == 'X' && board[0, 0] == 'X')
                || (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
                || (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
                || (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
                || (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X'))
            {
                Console.WriteLine("X won");
                playerX++;
                win = true;
                exit();                           
            }
            else if (((board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
                      || (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
                      || (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
                      || (board[2, 2] == 'O' && board[1, 1] == 'O' && board[0, 0] == 'O')
                      || (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
                      || (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
                      || (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
                      || (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O'))
            )
            {
                Console.WriteLine("O won");
                playerO++;
                win = true;
                exit();        
            }
            else
            {
                Tie();
            }
            return win;
        }
        private static void winners()
        {
            Console.WriteLine($"X score: {playerX}, O score: {playerO}, and tie: {PlayerTie}");
        }
    }
}
