namespace ConsoleApp1;

using System;

public class GameResults
{
    // Method to print the current state of the Tic-Tac-Toe board
    public static void PrintBoard(char[] board)
    {
        Console.Clear(); // Clears the console for a clean display before printing the board
        Console.WriteLine("Tic-Tac-Toe Game\n");

        for (int row = 0; row < 3; row++)
        {
            Console.Write(" ");
            for (int col = 0; col < 3; col++)
            {
                int index = row * 3 + col; // Convert row and column to the corresponding 1D array index
                Console.Write(board[index]); // Print the board cell content
                if (col < 2) Console.Write(" | "); // Print vertical dividers between columns
            }
            Console.WriteLine();

            if (row < 2) Console.WriteLine("---+---+---"); // Print horizontal dividers between rows
        }
        Console.WriteLine();
    }

    // Method to check if there is a winner based on the current board state
    public static char CheckWinner(char[] board)
    {
        char result = 'F' ; // Default result indicating no winner yet

        // Check all rows for a winner
        for (int i = 0; i < 3; i++)
        {
            int start = i * 3; // Starting index of the row
            if (board[start] != ' ' && board[start] == board[start + 1] && board[start + 1] == board[start + 2])
                return board[start]; // Return the winner (X or O)
        }

        // Check all columns for a winner
        for (int i = 0; i < 3; i++)
        {
            if (board[i] != ' ' && board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return board[i]; // Return the winner (X or O)
        }

        // Check main diagonal (top-left to bottom-right)
        if (board[0] != ' ' && board[0] == board[4] && board[4] == board[8])
            return board[0]; // Return the winner (X or O)

        // Check other diagonal (top-right to bottom-left)
        if (board[2] != ' ' && board[2] == board[4] && board[4] == board[6])
            return board[2]; // Return the winner (X or O)

        // Check for a draw (if all positions are filled and no winner is found)
        if (!board.Contains(' '))
            return 'D'; // Return 'D' to indicate a draw

        return result; // No winner yet, return false indicator
    }
}
