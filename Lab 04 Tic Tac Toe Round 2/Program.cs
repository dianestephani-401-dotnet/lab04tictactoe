using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        /// <summary>
        /// Sets up and starts the game, then shows winner
        /// </summary>
        static void StartGame()
        {
            Console.WriteLine("Let's play some Tic-Tac-Toe!");
            
            Console.WriteLine("Please enter the name of Player 1");
            string playerOneName = Console.ReadLine();
            Console.WriteLine("Please enter the name of Player 2");
            string playerTwoName = Console.ReadLine();

            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Name = playerOneName;
            playerTwo.Name = playerTwoName;
            playerOne.Marker = "X";
            playerTwo.Marker = "O";
            playerOne.IsTurn = true;

            Game game = new Game(playerOne, playerTwo);
            Player winner = game.Play();
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name} is the winner! Congratulations!");
            }
        }
    }
}
