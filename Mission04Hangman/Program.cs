namespace ConsoleApp1
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // Introduction to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player One will be 'X' and Player Two will be 'O'.\n");

            // Get Player One's name
            Console.Write("Player One, please enter your name: ");
            string playerOne = Console.ReadLine();

            // Get Player Two's name
            Console.Write("Player Two, please enter your name: ");
            string playerTwo = Console.ReadLine();

            // Initialize the game board (a 1D char array for the 3x3 board)
            char[] board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            // List to keep track of player moves (so we can alternate between 'X' and 'O')
            int moveCount = 0;

            // Game loop
            while (true)
            {
                int userChoice;
                string currentPlayer = (moveCount % 2 == 0) ? playerOne : playerTwo;
                char currentPlayerSymbol = (moveCount % 2 == 0) ? 'X' : 'O';

                // Display whose turn it is and the current symbol
                Console.WriteLine($"\n{currentPlayer}'s Turn ({currentPlayerSymbol})");

                // Print available positions
                GameResults.PrintBoard(board);

                while (true)
                {
                    try
                    {
                        // Make the prompt dynamic by addressing the player by name
                        Console.Write($"{currentPlayer}, pick a number between 1 and 9 to make your move: ");
                        userChoice = int.Parse(Console.ReadLine()) - 1; // Convert to 0-based index

                        // Validate move input
                        if (userChoice < 0 || userChoice > 8)
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                            continue;
                        }

                        // Check if the position is already taken
                        if (board[userChoice] != ' ')
                        {
                            Console.WriteLine("This position has already been taken. Please choose another.");
                            continue;
                        }
                        break;  // Valid move, exit the loop
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // Mark the board with the current player's symbol
                board[userChoice] = currentPlayerSymbol;
                moveCount++;

                // Check if there's a winner
                char winner = GameResults.CheckWinner(board);
                if (winner != 'F')
                {
                    // Print final board state
                    GameResults.PrintBoard(board);

                    if (winner == 'D')
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (winner == 'X')
                    {
                        Console.WriteLine($"{playerOne} wins!");
                    }
                    else if (winner == 'O')
                    {
                        Console.WriteLine($"{playerTwo} wins!");
                    }
                    break;  // End the game when there's a winner or draw
                }

                // If all moves are made and no winner, it's a draw
                if (moveCount == 9)
                {
                    GameResults.PrintBoard(board);
                    Console.WriteLine("It's a draw!");
                    break;
                }
            }

            // Final message after the game ends
            Console.WriteLine("\nThank you for playing Tic-Tac-Toe!");

            // Prevent the console from closing immediately after the game ends
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
