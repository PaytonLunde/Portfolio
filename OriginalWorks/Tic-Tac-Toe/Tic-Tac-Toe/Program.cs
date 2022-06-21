using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static int[,] img = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
        static bool playerCanWin = false;
        static bool computerCanWin = false;
        static int winningMoveCol;
        static int winningMoveRow;
        static void Main(string[] args)
        {
            DrawImg();
            Input();
            Console.ReadLine();
        }
        static void GameIsOver(string winner)
        {
            if (winner == "none")
            {
                Console.WriteLine("It's a tie");
            }
            else
            {
                Console.WriteLine("The game is over " + winner + " has won.");
            }
            Console.WriteLine("Press enter to play again");
            Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    img[i, j] = 0;
                }
            }
            Console.Clear();
            DrawImg();
            Input();
        }
        static void IsGameOver()
        {
            bool end = false;
            string who = "";
            bool noZeros = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (img[i, j] == 0)
                    {
                        noZeros = false;
                    }
                }
            }
            if (noZeros == true)
            {
                end = true;
                who = "None";
            }
            
            for (int control = 0; control < 3; control++)
            {
                if (img[control, 0] == img[control, 1] && img[control, 0] == img[control, 2] && img[control, 0] == 1)
                {
                    end = true;
                    who = "You";
                }
                if (img[0, control] == img[1, control] && img[0, control] == img[2, control] && img[0, control] == 1)
                {
                    end = true;
                    who = "You";
                }
                if (img[control, 0] == img[control, 1] && img[control, 0] == img[control, 2] && img[control, 0] == 2)
                {
                    end = true;
                    who = "Commputer";
                }
                if (img[0, control] == img[1, control] && img[0, control] == img[2, control] && img[0, control] == 2)
                {
                    end = true;
                    who = "Commputer";
                }
            }
            if (img[0, 0] == img[1,1] && img[2,2] == img[0,0] && img[0,0] == 1)
            {
                end = true;
                who = "You";
            }
            if (img[0, 0] == img[1, 1] && img[2, 2] == img[0, 0] && img[0, 0] == 2)
            {
                end = true;
                who = "Commputer";
            }
            if (img[0, 2] == img[1, 1] && img[2, 0] == img[0, 2] && img[0, 2] == 1)
            {
                end = true;
                who = "You";
            }
            if (img[0, 2] == img[1, 1] && img[2, 0] == img[0, 2] && img[0, 2] == 2)
            {
                end = true;
                who = "Commputer";
            }
            
            
            if (end == true)
            {
                GameIsOver(who);
            }
        }
        static void DrawImg()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (img[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (img[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (img[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("e");
                    }
                    if (j != 2)
                    {
                        Console.Write("|");
                    }
                    
                }
                Console.WriteLine("");
                if (i != 2)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
        static void Input()
        {
            int col = -1;
            int row = -1;
            Console.Write("What column (1, 2, or 3): ");
            try
            {
                col = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a number");
                Input();
            }
            Console.Write("What row (1, 2, or 3): ");
            try
            {
                row = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a number");
                Input();
            }
            row--;
            col--;
            if (row < 0 || row > 2)
            {
                Console.Clear();
                DrawImg();
                Console.WriteLine("You entered an invalid coordinates");
                Input();
            }
            if (col < 0 || col > 2)
            {
                Console.Clear();
                DrawImg();
                Console.WriteLine("You entered an invalid coordinates");
                Input();
            }
            if (img[row, col] == 0)
            {
                img[row, col] = 1;
            }
            else
            {
                Console.WriteLine("ERROR!!!!!!");
                Input();
            }
            DrawImg();
            IsGameOver();
            AITurn();
        }
        static void AITurn()
        {
            Console.Clear();
            CanWin();
            if (RNG(1, 100) >= 90)
            {
                bool done = false;
                while (done == false)
                {
                    int placeRow = RNG(1, 100);
                    int placeCol = RNG(1, 100);
                    placeRow = placeRow % 3;
                    placeCol = placeCol % 3;
                    if (img[placeRow, placeCol] == 0)
                    {
                        img[placeRow, placeCol] = 2;
                        done = true;
                    }
                }
            }
            else if (computerCanWin || playerCanWin)
            {
                img[winningMoveRow, winningMoveCol] = 2;
            }
            else if (img[1, 1] == 0)
            {
                img[1, 1] = 2;
            }
            else
            {
                bool done = false;
                while (done == false)
                {
                    
                    int placeRow = RNG(0, 2);
                    int placeCol = RNG(0, 2);
                    if (img[placeRow, placeCol] == 0)
                    {
                        img[placeRow, placeCol] = 2;
                        done = true;
                    }
                }
            }
            DrawImg();
            IsGameOver();
            Input();
        }
        static int RNG(int min, int max)
        {
            Random row = new Random();
            return row.Next(min, max);
        }
        
        static void CanWin()
        {
            playerCanWin = false;
            computerCanWin = false;
            if (img[0,0] == img[0,1] && img[0,0] != 0 && img[0, 2] == 0)
            {
                if (img[0, 0] == 2) {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
                if (img[0, 0] == 1)
                { 
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[0, 0] == img[0, 2] && img[0, 0] != 0 && img[0, 1] == 0)
            {
                if (img[0, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 0;
                    
                }
                if (img[0, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[0, 1] == img[0, 2] && img[0, 2] != 0 && img[0, 0] == 0)
            {
                if (img[0, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
                if (img[0, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[1, 0] == img[1, 1] && img[1, 0] != 0 && img[1, 2] == 0)
            {
                if (img[1, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 1;
                    
                }
                if (img[1, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[1, 0] == img[1, 2] && img[1, 0] != 0 && img[1, 1] == 0)
            {
                if (img[1, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
                if (img[1, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[1, 1] == img[1, 2] && img[1, 1] != 0 && img[1, 0] == 0)
            {
                if (img[1, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 1;
                    
                }
                if (img[1, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[2, 0] == img[2, 1] && img[2, 0] != 0 && img[2, 2] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[2, 0] == img[2, 2] && img[2, 0] != 0 && img[2, 1] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 2;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[2, 1] == img[2, 2] && img[2, 1] != 0 && img[2, 0] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 0] == img[1, 0] && img[0, 0] != 0 && img[2, 0] == 0)
            {
                if (img[1, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
                if (img[1, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[1, 0] == img[2, 0] && img[1, 0] != 0 && img[0, 0] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[0, 0] == img[2, 0] && img[2, 0] != 0 && img[1, 0] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 1;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[0, 1] == img[1, 1] && img[0, 1] != 0 && img[2, 1] == 0)
            {
                if (img[1, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 2;
                    
                }
                if (img[1, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 1] == img[2, 1] && img[2, 1] != 0 && img[1, 1] == 0)
            {
                if (img[2, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
                if (img[2, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[1, 1] == img[2, 1] && img[1, 1] != 0 && img[0, 1] == 0)
            {
                if (img[2, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 0;
                    
                }
                if (img[2, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[0, 2] == img[1, 2] && img[0, 2] != 0 && img[2, 2] == 0)
            {
                if (img[1, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
                if (img[1, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 2] == img[2, 2] && img[0, 2] != 0 && img[1, 2] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 1;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[2, 2] == img[1, 2] && img[2, 2] != 0 && img[0, 2] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[2, 2] == img[2, 1] && img[2, 2] != 0 && img[2, 0] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 0] == img[1, 1] && img[1, 1] != 0 && img[2, 2] == 0)
            {
                if (img[0, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
                if (img[0, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 0] == img[2, 2] && img[0, 0] != 0 && img[1, 1] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[2, 2] == img[1, 1] && img[1, 1] != 0 && img[0, 0] == 0)
            {
                if (img[2, 2] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
                if (img[2, 2] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 0;
                    
                }
            }
            else if (img[0, 2] == img[1, 1] && img[1, 1] != 0 && img[2, 0] == 0)
            {
                if (img[1, 1] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
                if (img[1, 1] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 0;
                    winningMoveRow = 2;
                    
                }
            }
            else if (img[0, 2] == img[2, 0] && img[0, 2] != 0 && img[1, 1] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 1;
                    winningMoveRow = 1;
                    
                }
            }
            else if (img[2, 0] == img[1, 1] && img[1, 1] != 0 && img[0, 2] == 0)
            {
                if (img[2, 0] == 2)
                {
                    computerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
                if (img[2, 0] == 1)
                {
                    playerCanWin = true;
                    winningMoveCol = 2;
                    winningMoveRow = 0;
                    
                }
            }
            
        }
    }
}
