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

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

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
