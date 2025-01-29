namespace ConsoleApp1;

using System;

public class GameResults
{
    /* The supporting class will:
     * - Receive the "board" array from the driver class
     * - Contain a method that prints the board based on the information passed to it
     * - Contain a method that receives the game board array as input and returns if there is a winner and who it was
     */

    // Method to print the current state of the Tic-Tac-Toe board
    public static void PrintBoard(char[,] board)
    {
        Console.Clear(); // Clears the console for a clean display
        Console.WriteLine("Tic-Tac-Toe Game\n");

        // Loop through each row of the board
        for (int row = 0; row < 3; row++)
        {
            Console.Write(" ");
            // Loop through each column of the board
            for (int col = 0; col < 3; col++)
            {
                Console.Write(board[row, col]); // Print the cell value (X, O, or empty space)
                if (col < 2) Console.Write(" | "); // Print vertical dividers between columns
            }
            Console.WriteLine(); // Move to the next line after printing a row

            if (row < 2) Console.WriteLine("---+---+---"); // Print horizontal dividers between rows
        }
        Console.WriteLine();
    }

    // Method to check if there is a winner
    public static char CheckWinner(char[,] board)
    {
        // Check all rows and columns
        for (int i = 0; i < 3; i++)
        {
            // Check if all three values in the current row are the same (and not empty)
            if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                return board[i, 0]; // Return the winning symbol (X or O)

            // Check if all three values in the current column are the same (and not empty)
            if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                return board[0, i]; // Return the winning symbol (X or O)
        }

        // Check the main diagonal (top-left to bottom-right)
        if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            return board[0, 0];

        // Check the other diagonal (top-right to bottom-left)
        if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            return board[0, 2];

        return ' '; // No winner yet, return a space to indicate the game continues
    }
}