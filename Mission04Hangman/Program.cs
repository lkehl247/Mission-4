namespace ConsoleApp1
{ public class Program
    {
    static void Main(string[] args)
    {
    Console.WriteLine("Welcome to Tic Tac Toe \r\nPlease enter your names\r\nPlayer One will be 'X', Player Two will be 'O'");
    List<int> choices = new List<int>();
    List<string> options = new List<string>
    {
        "0 = Top Left", "1 = Top Center", "2 = Top Right",
        "3 = Middle Left", "4 = Center", "5 = Middle Right",
        "6 = Bottom Left", "7 = Bottom Center", "8 = Bottom Right"
    };
    Console.WriteLine("Player One's Name: ");
    string playerOne = Console.ReadLine();
    Console.WriteLine("Player Two's Name: ");
    string playerTwo = Console.ReadLine();
    do
    {
        int userChoice;
        // Player One's turn
        Console.WriteLine($"{playerOne}'s Turn");
        Console.WriteLine("To make your move, pick a number");
        // Print available options
        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine(options[i]);
        }
        // Loop until a valid and available choice is entered
        while (true)
        {
            try
            {
                userChoice = int.Parse(Console.ReadLine());
                // Check if the choice is valid
                if (userChoice < 0 || userChoice > 8)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 8.");
                    continue;  // Retry if the number is out of range
                }
                // Check if the position has already been taken
                if (choices.Contains(userChoice))
                {
                    Console.WriteLine("This position has already been taken. Please choose another.");
                    continue;  // Retry if the position is already chosen
                }
                break;  // Valid choice, exit the loop
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        string result = userChoice switch
        {
            0 => "0 = Top Left",
            1 => "1 = Top Center",
            2 => "2 = Top Right",
            3 => "3 = Middle Left",
            4 => "4 = Center",
            5 => "5 = Middle Right",
            6 => "6 = Bottom Left",
            7 => "7 = Bottom Center",
            8 => "8 = Bottom Right",
        };
        options.Remove(result);  // Remove the selected option
        choices.Add(userChoice); // Add the chosen position
        PrintBoard(choices);
        // Player Two's turn (same process)
        Console.WriteLine($"{playerTwo}'s Turn");
        Console.WriteLine("To make your move, pick a number");
        // Print available options
        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine(options[i]);
        }
        while (true)
        {
            try
            {
                userChoice = int.Parse(Console.ReadLine());
                // Check if the choice is valid
                if (userChoice < 0 || userChoice > 8)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 8.");
                    continue;  // Retry if the number is out of range
                }
                // Check if the position has already been taken
                if (choices.Contains(userChoice))
                {
                    Console.WriteLine("This position has already been taken. Please choose another.");
                    continue;  // Retry if the position is already chosen
                }
                break;  // Valid choice, exit the loop
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        result = userChoice switch
        {
            0 => "0 = Top Left",
            1 => "1 = Top Center",
            2 => "2 = Top Right",
            3 => "3 = Middle Left",
            4 => "4 = Center",
            5 => "5 = Middle Right",
            6 => "6 = Bottom Left",
            7 => "7 = Bottom Center",
            8 => "8 = Bottom Right",
        };
        options.Remove(result);  // Remove the selected option
        choices.Add(userChoice); // Add the chosen position
        PrintBoard(choices);
    } while (CheckWinner(choices) != 'F' && CheckWinner(choices) != 'D');
    PrintBoard(choices);
    string letter = CheckWinner(choices);
    if (letter == "X")
    {
        Console.WriteLine($"{playerOne} Wins!");
    }
    else
    {
        Console.WriteLine($"{playerTwo} Wins!");
    }
}
}
    }
    