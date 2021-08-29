using System;
using System.Security.Cryptography;

namespace GameOfLife
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var GameBoard = GameStart.Start();

            while (true)
            {
            Printer.Print(GameBoard);
            GameBoard = LifeCycle.NextGeneration(GameBoard);
            }
            
        }


    }

  
}
