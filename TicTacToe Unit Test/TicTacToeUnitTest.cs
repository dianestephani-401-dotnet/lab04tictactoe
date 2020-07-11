using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToe_Unit_Test
{
    public class TicTacToeUnitTest
    {
        
        /// <summary>
        /// Tests if winner is checked correctly
        /// </summary>
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

        /// <summary>
        /// Tests if players switch correctly
        /// </summary>
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

        /// <summary>
        /// Tests if given input returns the correct position
        /// </summary>
        [Fact]
        public static void TestInputAndPosition()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game game = new Game(playerOne, playerTwo);

            Position position = Player.PositionForNumber(1);

            Assert.True(position.Row == 0 && position.Column == 0);
        }

        /// <summary>
        /// Tests if board is set correctly
        /// </summary>
        /// <param name="row">Row of the board to check</param>
        /// <param name="col">Column of the board to check</param>
        /// <param name="pos">Position on the board specified</param>
        [Theory]
        [InlineData(0, 0, "1")]
        [InlineData(0, 1, "2")]
        [InlineData(0, 2, "3")]
        [InlineData(1, 0, "4")]
        [InlineData(1, 1, "5")]
        [InlineData(1, 2, "6")]
        [InlineData(2, 0, "7")]
        [InlineData(2, 1, "8")]
        [InlineData(2, 2, "9")]
        public void TestBoardSetCorrectly(int row, int col, string pos)
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game game = new Game(playerOne, playerTwo);

            Assert.Equal(pos, game.Board.GameBoard[row, col]);
        }
    }
}
