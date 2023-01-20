using System;
using System.Threading;
public class TicTacToe : ITicTacToe
{
    char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    Player[][] cGrid;
    Player player;
    int choice;
    int chance = 1;
    int flag = 0;
    public void Move(int r, int c)
    {
        GetBoard();
        choice = int.Parse(Console.ReadLine());
        if (arr[choice] != 'X' && arr[choice] != 'O')
        {
            if (chance % 2 == 0) 
            {
                arr[choice] = 'O';
                player++;
            }
            else
            {
                arr[choice] = 'X';
                player++;
            }
        }
        else
        {
            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
            Console.WriteLine("\n");
            Console.WriteLine("Please wait 2 second board is loading again.....");
            Thread.Sleep(2000);
        }
    }

    public Player GetTurn()
    {
        if (chance % 2 == 0)
        {
            Console.WriteLine("Player 2 Chance");
            player = Player.O;

        }
        else
        {
            Console.WriteLine("Player 1 Chance");
            player = Player.X;
        }
        return 0;
    }

    public bool IsGameOver()
    {
        while (flag != 1 && flag != -1) ;
        Console.Clear();
        return true;
    }

    public Player GetWinner()
    {
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            flag = 1;
        }
        else if (arr[4] == arr[5] && arr[5] == arr[6])
        {
            flag = 1;
        }
        else if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            flag = 1;
        }
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            flag = 1;
        }
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            flag = 1;
        }
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            flag = 1;
        }
        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            flag = 1;
        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            flag = 1;
        }
        else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
        {
            flag = -1;
        }
        if (flag == 1)
        {
            Console.WriteLine("Player {0} has won", (chance % 2) + 1);
        }
        else
        {
            Console.WriteLine("Draw");
        }
        Console.ReadLine();
        return 0;
    }

    public Player[][] GetBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
        Console.WriteLine("     |     |      ");
        return cGrid;
    }

    public Player GetMarkAt(int r, int c)
    {
        return 0;
    }

}