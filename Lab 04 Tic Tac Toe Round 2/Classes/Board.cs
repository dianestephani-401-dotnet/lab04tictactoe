using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		/// <summary>
		/// Displays the current board to the Console
		/// </summary>
		public void DisplayBoard()
		{
			//TODO: Output the board to the console
			for(int i = 0; i < GameBoard.GetLength(0); i++)
			{
				int rowSize = GameBoard.GetLength(1);
				for(int j = 0; j < rowSize; j++)
				{
					Console.Write($" [{GameBoard[i,j]}] ");
				}
				Console.WriteLine("");
			}
		}
	}
}
