// See https://aka.ms/new-console-template for more information

using Mission4GroupTicTacToe;

internal class Program
{
    public static void Main(string[] args)
    {
        
        TicTacToeFunctions tttf = new TicTacToeFunctions();
        
        // initalize the array andd varibales
        char [,] boardArray = new char[3,3];
        bool gameOver = false;
        int playerTurn = 0;
        char BoardCharacter = ' ';
        string userInput = "";
        string winner = "";
        
        
        //welcome the user to the game

        Console.WriteLine("Lets play Tic Tac Toe:");
        Console.WriteLine("Each player must input the coordinates of the space they wish to go.");     
        Console.WriteLine("Enter the coordinates with a comma between ex. 1,0");
        Console.WriteLine("Player 1 (X) will go first and player 2 (O) will go second.");

        PrintBoard(boardArray);
        
        
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
            Console.WriteLine("Enter the coordinates:");
            playerTurn++;
            userInput = Console.ReadLine();
            
            
            //splits the input 
            string[] parts = userInput.Split(',');
            int row = int.Parse(parts[0]);
            int col = int.Parse(parts[1]);
            
            // replace board with the right 
            boardArray[row, col] = BoardCharacter;

            PrintBoard(boardArray);
            
            
            // check for the winner
            int WinnerInt = tttf.CheckWinner(boardArray);
            
            if (WinnerInt != 0)
            {
                Console.WriteLine("Player " + WinnerInt + " wins!");
                gameOver = true;
            }

        }

        // print the board using the method

        //check winner and notify a win and the winner



    }
}

