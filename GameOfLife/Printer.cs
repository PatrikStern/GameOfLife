using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static GameOfLife.GameStart;

namespace GameOfLife
{
    class Printer
    {
        const int rows = 40;
        const int colums = 100;
        
        public static void Print(Status[,] future, int timeout = 500)
        {
            var stringBuilder = new StringBuilder();

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < colums; column++)
                {

                    var cell = future[row, column];


                    stringBuilder.Append(cell == Status.Alive ? "O" : ".");
                }
                stringBuilder.Append("\n");
            }

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.Write(stringBuilder.ToString());
            Thread.Sleep(timeout);
        }
    }

    
}
