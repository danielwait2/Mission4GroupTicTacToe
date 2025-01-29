// See https://aka.ms/new-console-template for more information

using Mission4GroupTicTacToe;

internal class Program
{
    public static void Main(string[] args)
    {
        
        TicTacToeFunctions tttf = new TicTacToeFunctions();
        
        // initalize the array andd varibales
        char[,] boardArray = new char[3, 3]
        {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
        };
        bool gameOver = false;
        int playerTurn = 0;
        char BoardCharacter = ' ';
        string userInput = " ";
        string winner = "";
        
        
        //welcome the user to the game

        Console.WriteLine("Lets play Array Tic Tac Toe:");
        Console.WriteLine("Each player must input the coordinates of the space they wish to go.");     
        Console.WriteLine("Enter the coordinates with a comma between ex. 1,0");
        Console.WriteLine("Player 1 (X) will go first and player 2 (O) will go second.");

        tttf.PrintBoard(boardArray);
        
        
        // ask each player in turn for their choice and update the board array
        while (!gameOver && playerTurn < 9)
        {
            
            
            if (playerTurn % 2 == 0)
            {
                Console.WriteLine("Player 1's Turn");
                BoardCharacter = 'X';
            }
            else
            {
                Console.WriteLine("Player 2's Turn");
                BoardCharacter = 'O';
            }
            bool validInput = false;
            playerTurn++;
            
            while (!validInput)
            {
                Console.WriteLine("Enter the coordinates (row,col):");
                
                userInput = Console.ReadLine();

                // Validate input format
                string[] parts = userInput.Split(',');

                if (parts.Length == 2 && int.TryParse(parts[0], out int row) && int.TryParse(parts[1], out int col))
                {
                    // Ensure the coordinates are within bounds
                    if (row >= 0 && row < 3 && col >= 0 && col < 3)
                    {
                        // Ensure the spot is not already taken
                        if (boardArray[row, col] == '-')
                        {
                            boardArray[row, col] = BoardCharacter; // Mark the spot
                            validInput = true; // Valid input, break the loop
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken. Please choose a different spot.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates. Please enter numbers between 0 and 2 for both row and column.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please enter the coordinates as row,col (e.g., 0,1).");
                }
            }

            tttf.PrintBoard(boardArray);
            
            
            // check for the winner
            int WinnerInt = tttf.CheckWinner(boardArray);
            
            if (WinnerInt != 0)
            {
                Console.WriteLine("Player " + WinnerInt + " wins!");
                gameOver = true;
            }

            else if (playerTurn == 9)
            {
                Console.WriteLine(" Its a tie! You both lost!");
            }

        }

        // print the board using the method

        //check winner and notify a win and the winner



    }
}

