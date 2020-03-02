using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    
    
    public class RouletteBoard
    {
        public Cell[] ZeroCells { get; set; }
        public Cell[,] Board { get; set; }
        public int WinningNumber { get; set; }

       
        
        
        public RouletteBoard()
        {
            
            ZeroCells = new Cell[2];
            ZeroCells[0] = new Cell(37, CellColor.Green);
            ZeroCells[1] = new Cell(0, CellColor.Green);
            Board = new Cell[12, 3];
            Board[0, 0] = new Cell(1, CellColor.Red);
            Board[0, 1] = new Cell(2, CellColor.Black);
            Board[0, 2] = new Cell(3, CellColor.Red);
            Board[1, 0] = new Cell(4, CellColor.Black);
            Board[1, 1] = new Cell(5, CellColor.Red);
            Board[1, 2] = new Cell(6, CellColor.Black);
            Board[2, 0] = new Cell(7, CellColor.Red);
            Board[2, 1] = new Cell(8, CellColor.Black);
            Board[2, 2] = new Cell(9, CellColor.Red);
            Board[3, 0] = new Cell(10, CellColor.Black);
            Board[3, 1] = new Cell(11, CellColor.Black);
            Board[3, 2] = new Cell(12, CellColor.Red);
            Board[4, 0] = new Cell(13, CellColor.Black);
            Board[4, 1] = new Cell(14, CellColor.Red);
            Board[4, 2] = new Cell(15, CellColor.Black);
            Board[5, 0] = new Cell(16, CellColor.Red);
            Board[5, 1] = new Cell(17, CellColor.Black);
            Board[5, 2] = new Cell(18, CellColor.Red);
            Board[6, 0] = new Cell(19, CellColor.Red);
            Board[6, 1] = new Cell(20, CellColor.Black);
            Board[6, 2] = new Cell(21, CellColor.Red);
            Board[7, 0] = new Cell(22, CellColor.Black);
            Board[7, 1] = new Cell(23, CellColor.Red);
            Board[7, 2] = new Cell(24, CellColor.Black);
            Board[8, 0] = new Cell(25, CellColor.Red);
            Board[8, 1] = new Cell(26, CellColor.Black);
            Board[8, 2] = new Cell(27, CellColor.Red);
            Board[9, 0] = new Cell(28, CellColor.Black);
            Board[9, 1] = new Cell(29, CellColor.Black);
            Board[9, 2] = new Cell(30, CellColor.Red);
            Board[10, 0] = new Cell(31, CellColor.Black);
            Board[10, 1] = new Cell(32, CellColor.Red);
            Board[10, 2] = new Cell(33, CellColor.Black);
            Board[11, 0] = new Cell(34, CellColor.Red);
            Board[11, 1] = new Cell(35, CellColor.Black);
            Board[11, 2] = new Cell(36, CellColor.Red);          
 
        }

        
        
    }
}
