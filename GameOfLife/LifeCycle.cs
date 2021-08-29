using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameOfLife.GameStart;

namespace GameOfLife
{
    class LifeCycle
    {
        const int rows = 40;
        const int colums = 100;
        public static Status[,] NextGeneration(Status[,] present)
        {
            var nextGeneration = new Status[rows, colums];

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < colums; column++)
                {
                    var aliveNeighbors = 0;

                   if(row == 0 && column == 0)
                   {
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column + 1] == Status.Alive ? 1 : 0;
                   }
                   else if(row == 0 && column != 0 && column != 99)
                   {
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column - 1] == Status.Alive ? 1 : 0;
                   }
                    else if (row == 39 && column != 0 && column != 99)
                    {
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column - 1] == Status.Alive ? 1 : 0;
                    }
                    else if(row != 0 && row != 39 && column < 1)
                    {
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column + 1] == Status.Alive ? 1 : 0;
                    }
                   else if(row == 39 && column == 0)
                   {
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column + 1] == Status.Alive ? 1 : 0;
                   }
                   else if(column == 99 && row == 0)
                   {
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column - 1] == Status.Alive ? 1 : 0;
                   }
                   else if(row != 0 && row != 39 && column == 99)
                   {
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column - 1] == Status.Alive ? 1 : 0;
                   }
                   else if(row == 39 && column == 99)
                   {
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                   }
                    else
                    {
                        aliveNeighbors += present[row + 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row - 1, column - 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column + 1] == Status.Alive ? 1 : 0;
                        aliveNeighbors += present[row + 1, column - 1] == Status.Alive ? 1 : 0;
                    }
            
                    var currentCell = present[row, column];

                    if(currentCell == Status.Alive && aliveNeighbors == 2 || currentCell == Status.Alive && aliveNeighbors == 3)
                    {
                        nextGeneration[row, column] = Status.Alive;
                    }
                    else if(currentCell == Status.Dead && aliveNeighbors == 3)
                    {
                        nextGeneration[row, column] = Status.Alive;
                    }
                    else
                    {
                        nextGeneration[row, column] = Status.Dead;
                    }
                }
            }

            return nextGeneration;
        }
    }
}
