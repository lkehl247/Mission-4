namespace ConsoleApp1;

public class GameResults
{
    public static void PrintBoard(char[,] board)
    {
        Console.Clear();
        Console.WriteLine("Tic-Tac-Toe Game\n");
        
        for (int iCount1 = 0; iCount1 <  3; iCount1++)
        {
            Console.Write(" ");
            for (int iCount2 = 0; iCount2 < 3; iCount2++)
            {
                Console.Write(board[iCount1, iCount2]);
                if (iCount2 < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (iCount1 < 2) Console.WriteLine("---+---+---");
        }
        Console.WriteLine();
    }

    public static char CheckWinner(char[,] board)
    {
        // Check rows and columns
        for (int iCount1 = 0; iCount1 < 3; iCount1++)
        {
            if (board[iCount1, 0] != ' ' && board[iCount1, 0] == board[iCount1, 1] && board[iCount1, 1] == board[iCount1, 2])
                return board[iCount1, 0]; // Row match

            if (board[0, iCount1] != ' ' && board[0, iCount1] == board[1, iCount1] && board[1, iCount1] == board[2, iCount1])
                return board[0, iCount1]; // Column match
        }

        // Check diagonals
        if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            return board[0, 0];

        if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            return board[0, 2];

        return ' '; // No winner yet
    }
}