using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameStart
    {
        const int rows = 40;
        const int colums = 100;
        public static Status[,] Start()
        {
            var gameBoard = new Status[rows, colums];
            

            for (int row = 0; row < rows; row++)
            {
                for (int colum = 0; colum < colums; colum++)
                {
                    gameBoard[row, colum] = (Status) RandomNumberGenerator.GetInt32(0, 2);
                }
            }

            return gameBoard;
        }
        public enum Status
        {
            Dead,
            Alive
        }
    }
}
