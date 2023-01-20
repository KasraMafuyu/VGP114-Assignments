using System;
using System.Threading;
public class Program 
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Player1:X and Player2:O");
        Console.WriteLine("\n");
        TicTacToe ticTacToe = new TicTacToe();
        ticTacToe.GetTurn();
        ticTacToe.Move(1,3);
        ticTacToe.GetWinner();
    }
}