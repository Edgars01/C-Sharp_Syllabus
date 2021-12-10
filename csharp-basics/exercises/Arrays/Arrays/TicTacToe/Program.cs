using System;

namespace TicTacToe
{
    class Program
    {
        public static char[,] board = new char[3, 3];
        public static Random Random = new Random();
        public static bool gameWon = false;
        public static bool tie = false;
        public static int countMoves = 0;
        public static char playerTurn = Random.Next(0, 2) == 0 ? 'X' : 'O';

        private static void Main(string[] args)
        {
            Play();
        }

        private static void Play()
        {
            Console.WriteLine($"{playerTurn} starts!\n");
            InitBoard();

            do
            {
                DisplayBoard();
                firstCheckPoint:
                
                if (WinnerXO() == 'X' || WinnerXO() == 'O')
                {
                    gameWon = true;
                    Console.WriteLine($"{WinnerXO()} is winner!");
                    Exit();
                }
                else
                {
                    Console.Write($"{playerTurn}, choose your location X axis: ");
                    var inputX = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"{playerTurn}, choose your location Y axis: ");
                    var inputY = Convert.ToInt32(Console.ReadLine());
                   
                    Console.WriteLine();

                    if (0 <= inputY && inputY < 3 && 0 <= inputX && inputX < 3 && board[inputX, inputY] == ' ')
                    {
                        board[inputX, inputY] = playerTurn;
                        playerTurn = playerTurn == 'X' ? 'O' : 'X';
                    }
                    else
                    {
                        Console.WriteLine("Error try again!\n");
                        goto firstCheckPoint;
                    }

                    if (countMoves == 8 && WinnerXO() == '-')
                    {
                        tie = true;
                        Console.WriteLine("Tie!");
                        Exit();
                    }

                    countMoves++;
                    Console.Clear();
                }
                WinnerXO();
            } while (gameWon == false && tie == false);
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)           
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
        }

        private static char WinnerXO()
        {           
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2]) { 
                return board[0, 0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2]) {
                return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2]) {
                return board[2, 0];
            }
           
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0]) { 
                return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1]) {
                return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2]) {
                return board[0, 2];
            }
            
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) {
                return board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) {
                return board[0, 2];
            }
            else {
                return '-';
            }
        }

        private static void Exit()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            Console.WriteLine(" ");
            char ch = Console.ReadLine().ToUpper()[0];
            if (ch == 'N') {
                Environment.Exit(0);
            }
            Console.Clear();
            InitBoard();
            Play();
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("\n\n  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine();
        }   
    }
}