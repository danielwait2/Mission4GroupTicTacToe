namespace Mission4GroupTicTacToe;

public class TicTacToeFunctions
{
    public void PrintBoard(char[,] boardArray)
    {
        // create each row of the board using the different positions in the board array
        string row0 = $"     0   1   2  ";
        string row1 = $"0    {boardArray[0, 0]} | {boardArray[0, 1]} | {boardArray[0, 2]} ";
        string row2 = $"1    {boardArray[1, 0]} | {boardArray[1, 1]} | {boardArray[1, 2]} ";
        string row3 = $"2    {boardArray[2, 0]} | {boardArray[2, 1]} | {boardArray[2, 2]} ";
        string line = "    -----------";

        // print the board to the console
        Console.WriteLine($"{row0}\n\n{row1}\n{line}\n{row2}\n{line}\n{row3}");
      
    }

 
    // Check all the possible winner combinations and determine who won
    public int CheckWinner(char[,] boardArray)
    {
        int winner = 0;
        if ((((boardArray[0, 0] == boardArray[1, 0]) && (boardArray[1, 0] == boardArray[2, 0])) ||
            ((boardArray[0, 0] == boardArray[0, 1]) && (boardArray[0, 1] == boardArray[0, 2])) ||
            ((boardArray[0, 0] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[2, 2]))) && boardArray[0,0] != '-') 
            {
            // Check to see whose symbol was used in the winning combination and return that as the winner number
            if (boardArray[0,0] == 'X')
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
        }
        else if ((((boardArray[0, 1] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[2, 1])) ||
                ((boardArray[1, 0] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[1, 2])) ||
                ((boardArray[0, 2] == boardArray[1, 1]) && (boardArray[1, 1] == boardArray[2, 0]))) && boardArray[1, 1] != '-')
            {
            // Check to see whose symbol was used in the winning combination and return that as the winner number
            if (boardArray[1, 1] == 'X')
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
        }
        else if ((((boardArray[0, 2] == boardArray[1, 2]) && (boardArray[1, 2] == boardArray[2, 2])) ||
        ((boardArray[2, 0] == boardArray[2, 1]) && (boardArray[2, 1] == boardArray[2, 2]))) && boardArray[2, 2] != '-')
        {
            // Check to see whose symbol was used in the winning combination and return that as the winner number
            if (boardArray[2, 2] == 'X')
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
        }

        return winner;



    }
}