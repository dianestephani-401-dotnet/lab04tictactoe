using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToe_Unit_Test
{
    public class TicTacToeUnitTest
    {
        [Fact]
        public void TestForWinners()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Marker = "x";
            playerTwo.Marker = "o";
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard[0, 0] = playerOne.Marker;
            game.Board.GameBoard[0, 1] = playerOne.Marker;
            game.Board.GameBoard[0, 2] = playerOne.Marker;
            bool winnerCheck = game.CheckForWinner(game.Board);

            Assert.True(winnerCheck);
        }

        [Fact]
        public void TestForPlayerSwitch()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Marker = "x";
            playerTwo.Marker = "o";
            playerOne.IsTurn = true;
            Game game = new Game(playerOne, playerTwo);

            game.SwitchPlayer();
            Assert.True(playerTwo.IsTurn);

        }

        [Fact]
        public static void TestInputAndPosition()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game game = new Game(playerOne, playerTwo);

            Position position = Player.PositionForNumber(1);

            Assert.True(position.Row == 0 && position.Column == 0);
        }

        [Fact]
        public void TestPlayerName()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.Marker = "x";
            playerTwo.Marker = "o";
            Game game = new Game(playerOne, playerTwo);
        }
    }
}
