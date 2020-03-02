using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Cell
    {
        public int Value { get; set; }
        public CellColor Color { get; set; }


        public Cell()
        {

        }

        public Cell(int value, CellColor color)
        {
            this.Value = value;
            this.Color = color;
        }
    }


}
