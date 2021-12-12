using System;
using static System.Console;

namespace TicTacToe
{
    internal class Program
    {
        public static char[,] Board = new char[3, 3];
        public static Random Random = new Random();
        public static bool GameWon = false;
        public static bool Game_Tie = false;
        public static int CountMoves = 0;
        public static char ThisPlayerTurn = Random.Next(0, 2) == 0 ? 'X' : 'O';
        public static int InputX;
        public static int InputY;

        private static void Main(string[] args)
        {
            Play();
        }

        private static void Play()
        {
            GameWon = false;
            Game_Tie = false;
            CleanUpGameBoard();
            WriteLine($"{ThisPlayerTurn} starts!\n");
            do
            {
                DisplayBoard();
                GettingUserInput();
                ConfirmingUserInput();
                CountMoves++;
            } while (!GameWon && !Game_Tie);
        }

        private static void ResetPlayingBoard()
        {
            for (var r = 0; r < 3; r++)           
                for (var c = 0; c < 3; c++)
                    Board[r, c] = ' ';
        }

        public static void GettingUserInput()
        {
            WriteLine($"{ThisPlayerTurn}, choose your location X axis: ");
            InputX = Convert.ToInt32(ReadLine());
            WriteLine($"{ThisPlayerTurn}, choose your location Y axis: ");
            InputY = Convert.ToInt32(ReadLine());
            Clear();
        }

        private static void ConfirmingUserInput()
        {
            if (ConditionToConfirmInput())
            {
                Board[InputX, InputY] = ThisPlayerTurn;
                GettingTheWinner(ThisPlayerTurn);
                ThisPlayerTurn = ThisPlayerTurn == 'X' ? 'O' : 'X';
            }
            else
            {
                WriteLine("Error try again!\n");
                GettingUserInput();
            }
        }

        private static void GettingTheWinner(char winnerIsXorO)
        {
            if (Board[0, 0] == winnerIsXorO && Board[0, 1] == winnerIsXorO && Board[0, 1] == winnerIsXorO && Board[0, 2] == winnerIsXorO
                || Board[1, 0] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[1, 2] == winnerIsXorO
                || Board[2, 0] == winnerIsXorO && Board[2, 1] == winnerIsXorO && Board[2, 1] == winnerIsXorO && Board[2, 2] == winnerIsXorO
                || Board[0, 0] == winnerIsXorO && Board[1, 0] == winnerIsXorO && Board[1, 0] == winnerIsXorO && Board[2, 0] == winnerIsXorO
                || Board[0, 1] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[2, 1] == winnerIsXorO
                || Board[0, 2] == winnerIsXorO && Board[1, 2] == winnerIsXorO && Board[1, 2] == winnerIsXorO && Board[2, 2] == winnerIsXorO
                || Board[0, 0] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[2, 2] == winnerIsXorO
                || Board[0, 2] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[1, 1] == winnerIsXorO && Board[2, 0] == winnerIsXorO
               )
            {
                GameWon = true;
                WriteLine($"{ThisPlayerTurn} won!");
                Exit();
            }
            else if (CountMoves == 9)
            {
                Game_Tie = true;
                WriteLine("Tie");
                Exit();
            }
        }

        private static void Exit()
        {
            WriteLine("Do you want to continue (Y/N)? ");
            WriteLine(" ");
            char ch = ReadLine().ToUpper()[0];
            if (ch == 'N')
            {
                Environment.Exit(0);
            }
            ResetPlayingBoard();
            Play();
        }

        private static void DisplayBoard()
        {
            WriteLine("\n\n  0  " + Board[0, 0] + "|" + Board[0, 1] + "|" + Board[0, 2]);
            WriteLine("    --+-+--");
            WriteLine("  1  " + Board[1, 0] + "|" + Board[1, 1] + "|" + Board[1, 2]);
            WriteLine("    --+-+--");
            WriteLine("  2  " + Board[2, 0] + "|" + Board[2, 1] + "|" + Board[2, 2]);
            WriteLine("    --+-+--\n");
        }

        private static void CleanUpGameBoard()
        {
            ResetPlayingBoard();
            Clear();
        }

        private static bool ConditionToConfirmInput()
        {
           return 0 <= InputY && InputY < 3 && 0 <= InputX && InputX < 3 && Board[InputX, InputY] == ' ';
        }
    }
}